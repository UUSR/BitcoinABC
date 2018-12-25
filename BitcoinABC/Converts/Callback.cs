using System;

namespace BitcoinABC
{
    public class Callback : EventArgs
    {
        public string Message;

        public Callback()
        {
        }

        public Callback(string message)
        {
            this.Message = message;
        }
    }
}

