using System;
using System.Windows.Forms;

namespace BitcoinABC
{
    public partial class RandomForm : Form
    {
        public RandomForm()
        {
            InitializeComponent();
        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            var comp = KeyPair.Generate(true);
            var uncomp = KeyPair.Generate(false);

            WIF_comp_textBox.Text = comp.Private;
            Pub_comp_textBox.Text = comp.Public;

            WIF_uncomp_textBox.Text = uncomp.Private;
            Pub_uncomp_textBox.Text = uncomp.Public;
        }

        private void RandomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form randomForm = Application.OpenForms[0];
            randomForm.Show();
        }
    }
}
