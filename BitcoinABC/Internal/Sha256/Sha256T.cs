namespace BitcoinABC.Internal.Sha256
{
    class Sha256T
    {
        public uint[] S;
        public uint[] Buf;
        public uint Bytes;

        public Sha256T()
        {
            this.S = new uint[8];
            this.Buf = new uint[16];
            this.Bytes = 0U;
        }
    }
}
