using System;

namespace BitcoinABC.Internal.Secp256K1
{
    class Util
    {
        public static void Memcpy(Array src, uint srcOffset, Array dst, uint dstOffset, uint count)
        {
            if (count > (uint)int.MaxValue)
                throw new InvalidCastException(nameof(count));
            if (dstOffset > (uint)int.MaxValue)
                throw new InvalidCastException(nameof(dstOffset));
            if (srcOffset > (uint)int.MaxValue)
                throw new InvalidCastException(nameof(srcOffset));
            Buffer.BlockCopy(src, (int)srcOffset, dst, (int)dstOffset, (int)count);
        }

        public static void Memcpy(Array src, int srcOffset, Array dst, int dstOffset, int count)
        {
            Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
        }

        internal static void MemSet(byte[] dest, byte val, int size)
        {
            for (var index = 0; index < size && index < dest.Length; ++index)
                dest[index] = val;
        }

        internal static void MemSet(byte[] dest, uint skip, byte val, uint size)
        {
            for (var index = skip; index < size && (long)index < (long)dest.Length; ++index)
                dest[(int)index] = val;
        }

        internal static uint BitToUInt32Invers(byte[] b32, int index)
        {
            return (uint)((int)b32[index + 3] | (int)b32[index + 2] << 8 | (int)b32[index + 1] << 16 | (int)b32[index] << 24);
        }
    }
}
