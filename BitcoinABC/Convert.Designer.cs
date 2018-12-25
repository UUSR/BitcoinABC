namespace BitcoinABC
{
    partial class ConvertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BitcoinToHash_radioButton = new System.Windows.Forms.RadioButton();
            this.HashToBitcoin_radioButton = new System.Windows.Forms.RadioButton();
            this.PubkeyToHash_radioButton = new System.Windows.Forms.RadioButton();
            this.PubkeyToBitcoin_radioButton = new System.Windows.Forms.RadioButton();
            this.BitcoinToPubkey_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BitcoinToHash_radioButton
            // 
            this.BitcoinToHash_radioButton.AutoSize = true;
            this.BitcoinToHash_radioButton.Location = new System.Drawing.Point(15, 23);
            this.BitcoinToHash_radioButton.Name = "BitcoinToHash_radioButton";
            this.BitcoinToHash_radioButton.Size = new System.Drawing.Size(153, 17);
            this.BitcoinToHash_radioButton.TabIndex = 0;
            this.BitcoinToHash_radioButton.Text = "Bitcoin address to hash160";
            this.BitcoinToHash_radioButton.UseVisualStyleBackColor = true;
            this.BitcoinToHash_radioButton.CheckedChanged += new System.EventHandler(this.BitcoinToHash_radioButton_CheckedChanged);
            // 
            // HashToBitcoin_radioButton
            // 
            this.HashToBitcoin_radioButton.AutoSize = true;
            this.HashToBitcoin_radioButton.Location = new System.Drawing.Point(15, 46);
            this.HashToBitcoin_radioButton.Name = "HashToBitcoin_radioButton";
            this.HashToBitcoin_radioButton.Size = new System.Drawing.Size(154, 17);
            this.HashToBitcoin_radioButton.TabIndex = 1;
            this.HashToBitcoin_radioButton.Text = "Hash160 to bitcoin address";
            this.HashToBitcoin_radioButton.UseVisualStyleBackColor = true;
            this.HashToBitcoin_radioButton.CheckedChanged += new System.EventHandler(this.HashToBitcoin_radioButton_CheckedChanged);
            // 
            // PubkeyToHash_radioButton
            // 
            this.PubkeyToHash_radioButton.AutoSize = true;
            this.PubkeyToHash_radioButton.Location = new System.Drawing.Point(15, 69);
            this.PubkeyToHash_radioButton.Name = "PubkeyToHash_radioButton";
            this.PubkeyToHash_radioButton.Size = new System.Drawing.Size(130, 17);
            this.PubkeyToHash_radioButton.TabIndex = 2;
            this.PubkeyToHash_radioButton.Text = "Public key to hash160";
            this.PubkeyToHash_radioButton.UseVisualStyleBackColor = true;
            this.PubkeyToHash_radioButton.CheckedChanged += new System.EventHandler(this.PubkeyToHash_radioButton_CheckedChanged);
            // 
            // PubkeyToBitcoin_radioButton
            // 
            this.PubkeyToBitcoin_radioButton.AutoSize = true;
            this.PubkeyToBitcoin_radioButton.Location = new System.Drawing.Point(15, 92);
            this.PubkeyToBitcoin_radioButton.Name = "PubkeyToBitcoin_radioButton";
            this.PubkeyToBitcoin_radioButton.Size = new System.Drawing.Size(160, 17);
            this.PubkeyToBitcoin_radioButton.TabIndex = 3;
            this.PubkeyToBitcoin_radioButton.Text = "Public key to bitcoin address";
            this.PubkeyToBitcoin_radioButton.UseVisualStyleBackColor = true;
            this.PubkeyToBitcoin_radioButton.CheckedChanged += new System.EventHandler(this.PubkeyToBitcoin_radioButton_CheckedChanged);
            // 
            // BitcoinToPubkey_radioButton
            // 
            this.BitcoinToPubkey_radioButton.AutoSize = true;
            this.BitcoinToPubkey_radioButton.Checked = true;
            this.BitcoinToPubkey_radioButton.Location = new System.Drawing.Point(15, 115);
            this.BitcoinToPubkey_radioButton.Name = "BitcoinToPubkey_radioButton";
            this.BitcoinToPubkey_radioButton.Size = new System.Drawing.Size(160, 17);
            this.BitcoinToPubkey_radioButton.TabIndex = 4;
            this.BitcoinToPubkey_radioButton.TabStop = true;
            this.BitcoinToPubkey_radioButton.Text = "Bitcoin address to public key";
            this.BitcoinToPubkey_radioButton.UseVisualStyleBackColor = true;
            this.BitcoinToPubkey_radioButton.CheckedChanged += new System.EventHandler(this.BitcoinToPubkey_radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BitcoinToHash_radioButton);
            this.groupBox1.Controls.Add(this.BitcoinToPubkey_radioButton);
            this.groupBox1.Controls.Add(this.HashToBitcoin_radioButton);
            this.groupBox1.Controls.Add(this.PubkeyToBitcoin_radioButton);
            this.groupBox1.Controls.Add(this.PubkeyToHash_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Public bitcoin address:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 12;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(234, 75);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(332, 23);
            this.Convert.TabIndex = 13;
            this.Convert.Text = "Конверт";
            this.Convert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Public key:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(332, 20);
            this.textBox2.TabIndex = 15;
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 175);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConvertForm";
            this.Text = "Конвертер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Convert_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BitcoinToHash_radioButton;
        private System.Windows.Forms.RadioButton HashToBitcoin_radioButton;
        private System.Windows.Forms.RadioButton PubkeyToHash_radioButton;
        private System.Windows.Forms.RadioButton PubkeyToBitcoin_radioButton;
        private System.Windows.Forms.RadioButton BitcoinToPubkey_radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}