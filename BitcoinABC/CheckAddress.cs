using System;
using System.Windows.Forms;

namespace BitcoinABC
{
    public partial class CheckAddressForm : Form
    {
        public CheckAddressForm()
        {
            InitializeComponent();
        }
        private void CheckAddressForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form checkForm = Application.OpenForms[0];
            checkForm.Show();
            //Application.Exit();
            //this.Show();
        }
        private void Check_button_Click(object sender, EventArgs e)
        {
            try
            {
                string firstseen;
                Received_textBox.Text = LoadInfo.GetReceived(PublicAddress_textBox.Text) + " BTC";
                Send_textBox.Text = LoadInfo.GetSent(PublicAddress_textBox.Text) + " BTC";
                Balance_textBox.Text = LoadInfo.GetBalance(PublicAddress_textBox.Text) + " BTC";
                firstseen = LoadInfo.GetFirstSeen(PublicAddress_textBox.Text);
                FirstSeen_textBox.Text = firstseen;
                if (firstseen == "01.01.1970") Seen_label.Visible = true;
                else Seen_label.Visible = false;
            }
            catch (Exception ex)
            {
                Log.WriteError("Ошибка чекера. " + ex.Message);
            }
        }     
        private static string Epoch2String(int epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToShortDateString();
        }
    }
}
