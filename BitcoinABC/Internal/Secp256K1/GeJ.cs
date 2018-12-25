namespace BitcoinABC.Internal.Secp256K1
{
    internal class GeJ
    {
        public Fe X;
        public Fe Y;
        public Fe Z;
        public bool Infinity;

        public GeJ()
        {
            this.X = new Fe();
            this.Y = new Fe();
            this.Z = new Fe();
        }

        public GeJ(Fe xVal, Fe yVal, Fe zVal)
        {
            this.X = xVal ?? new Fe();
            this.Y = yVal ?? new Fe();
            this.Z = zVal ?? new Fe();
        }

        public GeJ Clone()
        {
            var x = this.X;
            var xVal = x != null ? x.Clone() : (Fe)null;
            var y = this.Y;
            var yVal = y != null ? y.Clone() : (Fe)null;
            var z = this.Z;
            var zVal = z != null ? z.Clone() : (Fe)null;
            return new GeJ(xVal, yVal, zVal);
        }
    }
}
