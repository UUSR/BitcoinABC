namespace BitcoinABC.Internal.Sha256
{
    internal class Rfc6979HmacSha256T
    {
        public byte[] V;
        public byte[] K;
        public bool Retry;

        public Rfc6979HmacSha256T()
        {
            this.V = new byte[32];
            this.K = new byte[32];
            this.Retry = false;
        }
    }
}
