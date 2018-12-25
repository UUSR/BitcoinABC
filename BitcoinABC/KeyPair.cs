using System.Linq;
using System.Text;
using BitcoinABC.Converts;

namespace BitcoinABC
{
    internal class KeyPair
    {
        
        internal readonly string Private;
        internal readonly string Public;

        private double Sent { get; set; }

        private double Balance { get; set; }

        private KeyPair(string priv, string pub)
        {
            Public = pub;
            Private = priv;
        }

        public static KeyPair Generate(bool compressed)
        {
            var randomKey = Secp256K1Manager.GenerateRandomKey();
            var array1 = new byte[1].Concat(Ripemd160Manager.GetHash(Sha256Manager.GetHash(Secp256K1Manager.GetPublicKey(randomKey, compressed)))).ToArray();
            var pub = Base58.Encode(array1.Concat(Sha256Manager.GetHash(Sha256Manager.GetHash(array1)).Take(4)).ToArray());
            byte[] array2;
            if (!compressed)
                array2 = new byte[1]
                {
                    128
                }.Concat(randomKey).ToArray();
            else
                array2 = new byte[1]
                {
                    128
                }.Concat(randomKey).Concat(new byte[1]
                {
                    1
                }).ToArray();
            return new KeyPair(Base58.Encode(array2.Concat(Sha256Manager.GetHash(Sha256Manager.GetHash(array2)).Take(4)).ToArray()), pub);
        }

        public static KeyPair Generate(string keyphrase, bool compressed)
        {
            var hash = Sha256Manager.GetHash(Encoding.UTF8.GetBytes(keyphrase));
            var array1 = new byte[1].Concat(Ripemd160Manager.GetHash(Sha256Manager.GetHash(Secp256K1Manager.GetPublicKey(hash, compressed)))).ToArray();
            var pub = Base58.Encode(array1.Concat(Sha256Manager.GetHash(Sha256Manager.GetHash(array1)).Take(4)).ToArray());
            byte[] array2;
            if (!compressed)
                array2 = new byte[1]
                {
                    128
                }.Concat(hash).ToArray();
            else
                array2 = new byte[1]
                {
                    128
                }.Concat(hash).Concat(new byte[1]
                {
                    1
                }).ToArray();
            return new KeyPair(Base58.Encode(array2.Concat(Sha256Manager.GetHash(Sha256Manager.GetHash(array2)).Take(4)).ToArray()), pub);
        }

        public override string ToString()
        {
            if (Balance <= 0.0 && Sent <= 0.0)
                return "private key: " + Private + "\npublic address: " + Public;
            return "private key: " + Private + "\npublic address: " + Public + "\nsent: " + Sent + "BTC, balance: " + Balance + "BTC\n";
        }
    }
}
