using System.Net;
using System.Text;

namespace BitcoinABC
{
    class ConvertAddress
    {
        private static WebClient wc = new WebClient();

        internal static string BitcoinToHash(string address)
        {
            var url = "https://blockchain.info/q/addresstohash/" + address;
            var num = 0;
        label_1:
            try
            {
                var bytes = wc.DownloadData(url);
                var result = "";
                result = Encoding.UTF8.GetString(bytes);
                return result;
            }
            catch
            {
                if (num >= 100)
                    return "";
                goto label_1;
            }
        }

        internal static string HashToBitcoin(string address)
        {
            var url = "https://blockchain.info/q/hashtoaddress/" + address;
            var num = 0;
        label_1:
            try
            {
                var bytes = wc.DownloadData(url);
                var result = "";
                result = Encoding.UTF8.GetString(bytes);
                return result;
            }
            catch
            {
                if (num >= 100)
                    return "";
                goto label_1;
            }
        }

        internal static string PubkeyToHash(string address)
        {
            var url = "https://blockchain.info/q/hashpubkey/" + address;
            var num = 0;
        label_1:
            try
            {
                var bytes = wc.DownloadData(url);
                var result = "";
                result = Encoding.UTF8.GetString(bytes);
                return result;
            }
            catch
            {
                if (num >= 100)
                    return "";
                goto label_1;
            }
        }

        internal static string PubkeyToBitcoin(string address)
        {
            var url = "https://blockchain.info/q/addrpubkey/" + address;
            var num = 0;
        label_1:
            try
            {
                var bytes = wc.DownloadData(url);
                var result = "";
                result = Encoding.UTF8.GetString(bytes);
                return result;
            }
            catch
            {
                if (num >= 100)
                    return "";
                goto label_1;
            }
        }

        internal static string BitcoinToPubkey(string address)
        {
            var url = "https://blockchain.info/q/pubkeyaddr/" + address;
            var num = 0;
        label_1:
            try
            {
                var bytes = wc.DownloadData(url);
                var result = "";
                result = Encoding.UTF8.GetString(bytes);
                return result;
            }
            catch
            {
                if (num >= 100)
                    return "";
                goto label_1;
            }
        }
    }
}
