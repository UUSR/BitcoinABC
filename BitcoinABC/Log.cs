using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BitcoinABC
{
    internal class Log
    {
        private const string LogPath = "log.txt";

        internal static void WriteError(string error)
        {
            try
            {
                IsCreate();
                using (var sw = new StreamWriter(LogPath, true, Encoding.Unicode))
                {
                    sw.Write("[" + DateTime.Now + "]" + "[" + "ошибка" + "]: " + error);
                    sw.WriteLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(("Не могу вести лог. \n" + e.Message), "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        internal static void NewSession()
        {
            try
            {
                IsCreate();
                using (var sw = new StreamWriter(LogPath, true, Encoding.Unicode))
                {
                    sw.WriteLine();
                    sw.Write("[" + DateTime.Now + "]: Храм головы пробужден. ");
                    sw.WriteLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(("Не могу вести лог. \n" + e.Message), "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        internal static void SessionEnd()
        {
            try
            {
                IsCreate();
                using (var sw = new StreamWriter(LogPath, true, Encoding.Unicode))
                {
                    sw.Write("[" + DateTime.Now + "]: Храм головы заснул. ");
                    sw.WriteLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(("Не могу вести лог. \n" + e.Message), "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static void IsCreate()
        {
            var file = new FileInfo(LogPath);
            if (!file.Exists)
            {
                var myFile = File.Create(LogPath);
                myFile.Close();
            }
        }
    }
}
