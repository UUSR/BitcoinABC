using BitcoinABC.Internal.Sha256;


namespace BitcoinABC
{
    class Sha256Manager
    {
        private readonly Sha256T _sha;

        public Sha256Manager()
        {
            this._sha = new Sha256T();
            Hash.Initialize(this._sha);
        }

        public void Write(byte[] data)
        {
            Hash.Write(this._sha, data, (uint)data.Length);
        }

        public void Write(byte[] data, int len)
        {
            Hash.Write(this._sha, data, (uint)len);
        }

        public byte[] FinalizeAndGetResult()
        {
            var out32 = new byte[32];
            Hash.Finalize(this._sha, out32);
            return out32;
        }

        public static byte[] GetHash(byte[] data)
        {
            var hash = new Sha256T();
            Hash.Initialize(hash);
            Hash.Write(hash, data, (uint)data.Length);
            var out32 = new byte[32];
            Hash.Finalize(hash, out32);
            return out32;
        }
    }
}
