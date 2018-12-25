using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinABC
{
   internal static class LoadInfo
    {
        private static readonly WebClient LoadWc = new WebClient();

        internal static double GetBalance(string pubkey)
        {
            var address = "https://blockchain.info/q/addressbalance/" + pubkey;
            var num = 0;
            label_1:
            try
            {
                var bytes = LoadInfo.LoadWc.DownloadData(address);
                var result = 0.0;
                double.TryParse(Encoding.UTF8.GetString(bytes), out result);
                return result / 100000000.0;
            }
            catch
            {
                if (num >= 100)
                    return 0.0;
                goto label_1;
            }
        }

        internal static double GetSent(string pubkey)
        {
            var address = "https://blockchain.info/q/getsentbyaddress/" + pubkey;
            var num = 0;
            label_1:
            try
            {
                var bytes = LoadInfo.LoadWc.DownloadData(address);
                var result = 0.0;
                double.TryParse(Encoding.UTF8.GetString(bytes), out result);
                return result / 100000000.0;
            }
            catch
            {
                if (num >= 100)
                    return 0.0;
                goto label_1;
            }
        }

        internal static double GetReceived(string pubkey)
        {
            var address = "https://blockchain.info/q/getreceivedbyaddress/"+pubkey;
            var num = 0;
            label_1:
            try
            {
                var bytes = LoadInfo.LoadWc.DownloadData(address);
                var result = 0.0;
                double.TryParse(Encoding.UTF8.GetString(bytes), out result);
                return result / 100000000.0;
            }
            catch
            {
                if (num >= 100)
                    return 0.0;
                goto label_1;
            }
        }

        internal static string GetFirstSeen(string pubkey)
        {
            var address = "https://blockchain.info/q/addressfirstseen/" + pubkey;
            var num = 0;
            label_1:
            try
            {
                var bytes = LoadInfo.LoadWc.DownloadData(address);
                var result = 0;
                int.TryParse(Encoding.UTF8.GetString(bytes), out result);
                return Epoch2String(result);
            }
            catch
            {
                if (num >= 100)
                    return Epoch2String(0);
                goto label_1;
            }
        }

        internal static int GetFirstSeenInt(string pubkey)
        {
            var address = "https://blockchain.info/q/addressfirstseen/" + pubkey;
            var num = 0;
            label_1:
            try
            {
                var bytes = LoadInfo.LoadWc.DownloadData(address);
                var result = 0;
                int.TryParse(Encoding.UTF8.GetString(bytes), out result);
                return result;
            }
            catch
            {
                if (num >= 100)
                    return 0;
                goto label_1;
            }
        }

        private static string Epoch2String(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortDateString();
        }
    }
}
