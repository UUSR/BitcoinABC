using BitcoinABC.Internal.Sha256;
using System;
using System.Text;

namespace BitcoinABC.Internal.Secp256K1
{
    internal class EcMultGen
    {
        public static void ContextInit(EcmultGenContext ctx)
        {
            ctx.Prec = (GeStorage[][])null;
        }

        public static void ContextBuild(EcmultGenContext ctx, EventHandler<Callback> cb)
        {
            var r1 = new Ge[1024];
            var r2 = new GeJ();
            var geJ1 = new GeJ();
            if (ctx.Prec != null)
                return;
            ctx.PrecInit();
            Group.secp256k1_gej_set_ge(r2, Group.Secp256K1GeConstG);
            var bytes = Encoding.UTF8.GetBytes("The scalar for this x is unknown");
            var fe = new Fe();
            var ge = new Ge();
            Field.SetB32(fe, bytes);
            Group.secp256k1_ge_set_xo_var(ge, fe, false);
            Group.secp256k1_gej_set_ge(geJ1, ge);
            Group.secp256k1_gej_add_ge_var(geJ1, geJ1, Group.Secp256K1GeConstG, (Fe)null);
            var a = new GeJ[1024];
            for (var index = 0; index < a.Length; ++index)
                a[index] = new GeJ();
            var geJ2 = r2.Clone();
            var geJ3 = geJ1.Clone();
            for (var index1 = 0; index1 < 64; ++index1)
            {
                a[index1 * 16] = geJ3.Clone();
                for (var index2 = 1; index2 < 16; ++index2)
                    Group.secp256k1_gej_add_var(a[index1 * 16 + index2], a[index1 * 16 + index2 - 1], geJ2, (Fe)null);
                for (var index2 = 0; index2 < 4; ++index2)
                    Group.secp256k1_gej_double_var(geJ2, geJ2, (Fe)null);
                Group.secp256k1_gej_double_var(geJ3, geJ3, (Fe)null);
                if (index1 == 62)
                {
                    Group.secp256k1_gej_neg(geJ3, geJ3);
                    Group.secp256k1_gej_add_var(geJ3, geJ3, geJ1, (Fe)null);
                }
            }
            for (var index = 0; index < r1.Length; ++index)
                r1[index] = new Ge();
            Group.secp256k1_ge_set_all_gej_var(r1, a, 1024, cb);
            for (var index1 = 0; index1 < 64; ++index1)
            {
                for (var index2 = 0; index2 < 16; ++index2)
                    Group.ToStorage(ctx.Prec[index1][index2], r1[index1 * 16 + index2]);
            }
            EcMultGen.Blind(ctx, (byte[])null);
        }

        public static bool ContextIsBuilt(EcmultGenContext ctx)
        {
            return ctx.Prec != null;
        }

        public static void secp256k1_ecmult_gen(EcmultGenContext ctx, out GeJ r, Scalar gn)
        {
            var ge = new Ge();
            var geStorage = new GeStorage();
            r = ctx.Initial.Clone();
            var r1 = new Scalar();
            Scalar.Add(r1, gn, ctx.Blind);
            ge.Infinity = false;
            for (var index1 = 0; index1 < 64; ++index1)
            {
                var bits = r1.GetBits(index1 * 4, 4);
                for (var index2 = 0; index2 < 16; ++index2)
                    Group.StorageCmov(geStorage, ctx.Prec[index1][index2], (long)index2 == (long)bits);
                Group.FromStorage(ge, geStorage);
                Group.GeJAddGe(r, r, ge);
            }
            Group.secp256k1_ge_clear(ge);
            Scalar.Clear(r1);
        }

        public static void Blind(EcmultGenContext ctx, byte[] seed32)
        {
            var scalar = new Scalar();
            var fe = new Fe();
            var rng = new Rfc6979HmacSha256T();
            var numArray = new byte[64];
            if (seed32 == null)
            {
                Group.secp256k1_gej_set_ge(ctx.Initial, Group.Secp256K1GeConstG);
                Group.secp256k1_gej_neg(ctx.Initial, ctx.Initial);
                ctx.Blind.SetInt(1U);
            }
            var b32 = Scalar.GetB32(ctx.Blind);
            Util.Memcpy((Array)b32, 0, (Array)numArray, 0, 32);
            if (seed32 != null)
                Util.Memcpy((Array)seed32, 0, (Array)numArray, 32, 32);
            Hash.Rfc6979HmacSha256Initialize(rng, numArray, seed32 != null ? 64U : 32U);
            Util.MemSet(numArray, (byte)0, numArray.Length);
            bool overflow;
            do
            {
                Hash.Rfc6979HmacSha256Generate(rng, b32, 32);
                overflow = !Field.SetB32(fe, b32) | Field.IsZero(fe);
            }
            while (overflow);
            Group.secp256k1_gej_rescale(ctx.Initial, fe);
            Field.Clear(fe);
            do
            {
                Hash.Rfc6979HmacSha256Generate(rng, b32, 32);
                Scalar.SetB32(scalar, b32, ref overflow);
                overflow |= Scalar.IsZero(scalar);
            }
            while (overflow);
            Hash.Rfc6979HmacSha256Finalize(rng);
            Util.MemSet(b32, (byte)0, 32);
            GeJ r;
            EcMultGen.secp256k1_ecmult_gen(ctx, out r, scalar);
            Scalar.Negate(scalar, scalar);
            ctx.Blind = scalar.Clone();
            ctx.Initial = r.Clone();
            Scalar.Clear(scalar);
            Group.secp256k1_gej_clear(r);
        }
    }
}
