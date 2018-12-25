using System;

namespace BitcoinABC.Internal.Secp256K1
{
    internal class ContextStruct
    {
        public EcMultContext EcMultCtx;
        public EcmultGenContext EcMultGenCtx;
        public EventHandler<Callback> IllegalCallback;
        public EventHandler<Callback> ErrorCallback;

        public ContextStruct()
        {
            this.EcMultCtx = new EcMultContext();
            this.EcMultGenCtx = new EcmultGenContext();
        }
    }
}