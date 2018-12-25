using System;
using System.Windows.Forms;
using System.Threading;

namespace BitcoinABC
{
    public partial class Main : Form
    {

        public Main()
        {
            Log.NewSession();
            InitializeComponent();
        }

        private void проверкаАдресаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var checkForm = new CheckAddressForm();
                this.Hide();
                checkForm.Show();
            }
            catch (Exception e3)
            {
                Log.WriteError("Ошибка инициализации проверки адреса. " + e3.Message);
                MessageBox.Show(("Ошибка инициализации проверки адреса. \n" + e3.Message), "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void конвертерАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var convertForm = new ConvertForm();
                this.Hide();
                convertForm.Show();
            }
            catch (Exception e2)
            {
                Log.WriteError("Ошибка инициализации конвертера. " + e2.Message);
                MessageBox.Show(("Ошибка инициализации конвертера. \n" + e2.Message), "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void генераторАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var randomForm = new RandomForm();
            this.Hide();
            randomForm.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log.SessionEnd();
        }       
    }
}
