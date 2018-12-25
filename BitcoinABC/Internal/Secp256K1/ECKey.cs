namespace BitcoinABC.Internal.Secp256K1
{
    internal class ECKey
    {
        public static bool PubkeySerialize(Ge elem, byte[] pub, ref int size, bool compressed)
        {
            if (Group.secp256k1_ge_is_infinity(elem))
                return false;
            Field.NormalizeVar(elem.X);
            Field.NormalizeVar(elem.Y);
            Field.GetB32(pub, 1, elem.X);
            if (compressed)
            {
                size = 33;
                pub[0] = (byte)(2 | (Field.IsOdd(elem.Y) ? 1 : 0));
            }
            else
            {
                size = 65;
                pub[0] = (byte)4;
                Field.GetB32(pub, 33, elem.Y);
            }
            return true;
        }
    }
}
