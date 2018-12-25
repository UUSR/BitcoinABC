namespace BitcoinABC.Internal.Secp256K1
{
    internal delegate bool NonceFunction(byte[] nonce32, byte[] msg32, byte[] key32, byte[] algo16, byte[] data, uint attempt);
}
