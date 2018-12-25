namespace BitcoinABC.Internal.Sha256
{
    internal class HmacSha256T
    {
        public Sha256T Inner;
        public Sha256T Outer;

        public HmacSha256T()
        {
            this.Inner = new Sha256T();
            this.Outer = new Sha256T();
        }
    }
}
