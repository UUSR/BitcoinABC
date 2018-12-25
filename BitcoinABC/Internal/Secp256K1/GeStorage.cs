namespace BitcoinABC.Internal.Secp256K1
{
    internal class GeStorage
    {
        public FeStorage X;
        public FeStorage Y;

        public GeStorage()
        {
            this.X = new FeStorage();
            this.Y = new FeStorage();
        }
    }
}
