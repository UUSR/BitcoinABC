namespace BitcoinABC
{
    partial class RandomForm
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
            this.Generate_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WIF_comp_textBox = new System.Windows.Forms.TextBox();
            this.Pub_comp_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WIF_uncomp_textBox = new System.Windows.Forms.TextBox();
            this.Pub_uncomp_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate_button
            // 
            this.Generate_button.Location = new System.Drawing.Point(12, 193);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.Size = new System.Drawing.Size(486, 23);
            this.Generate_button.TabIndex = 0;
            this.Generate_button.Text = "Генерация.";
            this.Generate_button.UseVisualStyleBackColor = true;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WIF_comp_textBox);
            this.groupBox1.Controls.Add(this.Pub_comp_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compressed:";
            // 
            // WIF_comp_textBox
            // 
            this.WIF_comp_textBox.Location = new System.Drawing.Point(121, 46);
            this.WIF_comp_textBox.Name = "WIF_comp_textBox";
            this.WIF_comp_textBox.ReadOnly = true;
            this.WIF_comp_textBox.Size = new System.Drawing.Size(359, 20);
            this.WIF_comp_textBox.TabIndex = 3;
            // 
            // Pub_comp_textBox
            // 
            this.Pub_comp_textBox.Location = new System.Drawing.Point(121, 20);
            this.Pub_comp_textBox.Name = "Pub_comp_textBox";
            this.Pub_comp_textBox.ReadOnly = true;
            this.Pub_comp_textBox.Size = new System.Drawing.Size(359, 20);
            this.Pub_comp_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private key (WIF): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public key: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WIF_uncomp_textBox);
            this.groupBox2.Controls.Add(this.Pub_uncomp_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uncompressed: ";
            // 
            // WIF_uncomp_textBox
            // 
            this.WIF_uncomp_textBox.Location = new System.Drawing.Point(121, 45);
            this.WIF_uncomp_textBox.Name = "WIF_uncomp_textBox";
            this.WIF_uncomp_textBox.ReadOnly = true;
            this.WIF_uncomp_textBox.Size = new System.Drawing.Size(359, 20);
            this.WIF_uncomp_textBox.TabIndex = 5;
            // 
            // Pub_uncomp_textBox
            // 
            this.Pub_uncomp_textBox.Location = new System.Drawing.Point(121, 19);
            this.Pub_uncomp_textBox.Name = "Pub_uncomp_textBox";
            this.Pub_uncomp_textBox.ReadOnly = true;
            this.Pub_uncomp_textBox.Size = new System.Drawing.Size(359, 20);
            this.Pub_uncomp_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Private key (WIF): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Public key: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Генератор пары публичный приватный ключь.";
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 227);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Generate_button);
            this.Name = "RandomForm";
            this.Text = "Генерация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RandomForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox WIF_comp_textBox;
        private System.Windows.Forms.TextBox Pub_comp_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox WIF_uncomp_textBox;
        private System.Windows.Forms.TextBox Pub_uncomp_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}