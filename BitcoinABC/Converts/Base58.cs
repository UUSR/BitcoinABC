using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace BitcoinABC.Converts
{
    public class Base58
    {
        protected const int CheckSumSizeInBytes = 4;
        protected const string Hexdigits = "0123456789abcdefABCDEF";
        protected const string Digits = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz";

        public static byte[] RemoveCheckSum(byte[] data)
        {
            var numArray = new byte[data.Length - 4];
            Buffer.BlockCopy((Array)data, 0, (Array)numArray, 0, data.Length - 4);
            return numArray;
        }

        public static string Encode(byte[] data)
        {
            var bigInteger = (BigInteger)0;
            for (var index = 0; index < data.Length; ++index)
                bigInteger = bigInteger * (BigInteger)256 + (BigInteger)data[index];
            var str = "";
            while (bigInteger > 0L)
            {
                var index = (int)(bigInteger % (BigInteger)58);
                bigInteger /= (BigInteger)58;
                str = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz"[index].ToString() + str;
            }
            for (var index = 0; index < data.Length && (int)data[index] == 0; ++index)
                str = "1" + str;
            return str;
        }

        public static byte[] Decode(string base58)
        {
            var bigInteger = (BigInteger)0;
            for (var index = 0; index < base58.Length; ++index)
            {
                var num = "123456789ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz".IndexOf(base58[index]);
                if (num < 0)
                    throw new FormatException(string.Format("Invalid Base58 character `{0}` at position {1}", (object)base58[index], (object)index));
                bigInteger = bigInteger * (BigInteger)58 + (BigInteger)num;
            }
            return Enumerable.Repeat<byte>((byte)0, base58.TakeWhile<char>((Func<char, bool>)(c => (int)c == 49)).Count<char>()).Concat<byte>(((IEnumerable<byte>)bigInteger.ToByteArray()).Reverse<byte>().SkipWhile<byte>((Func<byte, bool>)(b => (int)b == 0))).ToArray<byte>();
        }

        protected static byte[] DoubleHash(byte[] s)
        {
            return Sha256Manager.GetHash(Sha256Manager.GetHash(s));
        }

        protected static byte[] CutLastBytes(byte[] source, int cutCount)
        {
            var numArray = new byte[source.Length - cutCount];
            Array.Copy((Array)source, (Array)numArray, numArray.Length);
            return numArray;
        }

        protected static byte[] AddLastBytes(byte[] source, int addCount)
        {
            var numArray = new byte[source.Length + addCount];
            Array.Copy((Array)source, (Array)numArray, source.Length);
            return numArray;
        }

        protected static byte[] CutFirstBytes(byte[] source, int cutCount)
        {
            var numArray = new byte[source.Length - cutCount];
            Array.Copy((Array)source, cutCount, (Array)numArray, 0, numArray.Length);
            return numArray;
        }

        protected static byte[] AddFirstBytes(byte[] source, int addCount)
        {
            var numArray = new byte[source.Length + addCount];
            Array.Copy((Array)source, 0, (Array)numArray, addCount, source.Length);
            return numArray;
        }
    }
}
