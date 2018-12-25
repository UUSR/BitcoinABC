namespace BitcoinABC.Internal.Secp256K1
{
    internal class EcmultGenContext
    {
        public GeStorage[][] Prec;
        public Scalar Blind;
        public GeJ Initial;

        public void PrecInit()
        {
            this.Prec = new GeStorage[64][];
            for (var index1 = 0; index1 < 64; ++index1)
            {
                this.Prec[index1] = new GeStorage[16];
                for (var index2 = 0; index2 < 16; ++index2)
                    this.Prec[index1][index2] = new GeStorage();
            }
            this.Blind = new Scalar();
            this.Initial = new GeJ();
        }
    }
}
