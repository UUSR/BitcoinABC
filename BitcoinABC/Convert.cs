using System;
using System.Windows.Forms;

namespace BitcoinABC
{
    public partial class ConvertForm : Form
    {
        private static string _bitcoin = "Public bitcoin address: ";
        private static string _hash160 = "Hash160: ";
        private static string _pubKey = "Public key: ";
        private readonly Log _log = new Log();
        private static ConvertAddress converter = new ConvertAddress();

        public ConvertForm()
        {
            InitializeComponent();
        }

        private void Convert_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form convertForm = Application.OpenForms[0];
            convertForm.Show();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (BitcoinToHash_radioButton.Checked)
                {
                    textBox2.Text = ConvertAddress.BitcoinToHash(textBox1.Text);
                }

                if (HashToBitcoin_radioButton.Checked)
                {
                    textBox2.Text = ConvertAddress.HashToBitcoin(textBox1.Text);
                }

                if (PubkeyToHash_radioButton.Checked)
                {
                    textBox2.Text = ConvertAddress.PubkeyToHash(textBox1.Text);
                }

                if (PubkeyToBitcoin_radioButton.Checked)
                {
                    textBox2.Text = ConvertAddress.PubkeyToBitcoin(textBox1.Text);
                }

                if (BitcoinToPubkey_radioButton.Checked)
                {
                    textBox2.Text = ConvertAddress.BitcoinToPubkey(textBox1.Text);
                }
            }
            catch (Exception exception)
            {
                if (exception.GetType().Name == "WebException")
                {
                    MessageBox.Show("Адрес не существует.", "Опять ненаход", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    Log.WriteError("Ошибка конвертера. " + exception.Message);
                    MessageBox.Show(("Ошибка конвертера. \n" + exception.Message), "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void BitcoinToHash_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = _bitcoin;
            label2.Text = _hash160;
        }

        private void HashToBitcoin_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = _hash160;
            label2.Text = _bitcoin;
        }

        private void PubkeyToHash_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = _pubKey;
            label2.Text = _hash160;
        }

        private void PubkeyToBitcoin_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = _pubKey;
            label2.Text = _bitcoin;
        }

        private void BitcoinToPubkey_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = _bitcoin;
            label2.Text = _pubKey;
        }
    }
}
