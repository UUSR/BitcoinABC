namespace BitcoinABC.Internal.Secp256K1
{
    internal class Ge
    {
        public Fe X;
        public Fe Y;
        public bool Infinity;

        public Ge()
        {
            this.X = new Fe();
            this.Y = new Fe();
        }

        public Ge(uint[] xarr, uint[] yarr)
        {
            this.X = new Fe(xarr);
            this.Y = new Fe(yarr);
        }
    }
}
