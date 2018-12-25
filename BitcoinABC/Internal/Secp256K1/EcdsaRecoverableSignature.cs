namespace BitcoinABC.Internal.Secp256K1
{
    internal class EcdsaRecoverableSignature
    {
        public byte[] Data = new byte[65];
        public const int Size = 65;
    }
}
