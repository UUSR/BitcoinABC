using System;

namespace BitcoinABC.Internal.Secp256K1
{
    internal class Fe
    {
        public uint[] N;

        public uint this[int index]
        {
            get
            {
                return this.N[index];
            }
        }

        public Fe()
        {
            this.N = new uint[10];
        }

        public Fe(uint[] arr)
        {
            this.N = arr;
        }

        public Fe(Fe other)
        {
            this.N = new uint[other.N.Length];
            Array.Copy((Array)other.N, (Array)this.N, other.N.Length);
        }

        public Fe Clone()
        {
            return new Fe(this);
        }
    }
}

