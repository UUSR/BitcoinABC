using System;

namespace BitcoinABC.Internal.Secp256K1
{
    internal class FeStorage
    {
        public uint[] N;

        public FeStorage()
        {
            this.N = new uint[8];
        }

        public FeStorage(uint[] arr)
        {
            this.N = arr;
        }

        public FeStorage(FeStorage other)
        {
            this.N = new uint[other.N.Length];
            Array.Copy((Array)other.N, (Array)this.N, other.N.Length);
        }

        public FeStorage Clone()
        {
            return new FeStorage(this);
        }
    }
}