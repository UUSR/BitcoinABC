namespace BitcoinABC
{
    partial class CheckAddressForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PublicAddress_textBox = new System.Windows.Forms.TextBox();
            this.Check_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Received_textBox = new System.Windows.Forms.TextBox();
            this.Send_textBox = new System.Windows.Forms.TextBox();
            this.Balance_textBox = new System.Windows.Forms.TextBox();
            this.FirstSeen_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Seen_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public bitcoin address: ";
            // 
            // PublicAddress_textBox
            // 
            this.PublicAddress_textBox.Location = new System.Drawing.Point(135, 13);
            this.PublicAddress_textBox.Name = "PublicAddress_textBox";
            this.PublicAddress_textBox.Size = new System.Drawing.Size(371, 20);
            this.PublicAddress_textBox.TabIndex = 1;
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(135, 39);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(371, 23);
            this.Check_button.TabIndex = 2;
            this.Check_button.Text = "Проверить";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total received:";
            // 
            // Received_textBox
            // 
            this.Received_textBox.Location = new System.Drawing.Point(135, 71);
            this.Received_textBox.Name = "Received_textBox";
            this.Received_textBox.Size = new System.Drawing.Size(371, 20);
            this.Received_textBox.TabIndex = 4;
            // 
            // Send_textBox
            // 
            this.Send_textBox.Location = new System.Drawing.Point(135, 97);
            this.Send_textBox.Name = "Send_textBox";
            this.Send_textBox.Size = new System.Drawing.Size(371, 20);
            this.Send_textBox.TabIndex = 5;
            // 
            // Balance_textBox
            // 
            this.Balance_textBox.Location = new System.Drawing.Point(135, 123);
            this.Balance_textBox.Name = "Balance_textBox";
            this.Balance_textBox.Size = new System.Drawing.Size(371, 20);
            this.Balance_textBox.TabIndex = 6;
            // 
            // FirstSeen_textBox
            // 
            this.FirstSeen_textBox.Location = new System.Drawing.Point(135, 149);
            this.FirstSeen_textBox.Name = "FirstSeen_textBox";
            this.FirstSeen_textBox.Size = new System.Drawing.Size(371, 20);
            this.FirstSeen_textBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total send:";
            this.label3.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final balance: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "First seen:";
            // 
            // Seen_label
            // 
            this.Seen_label.AutoSize = true;
            this.Seen_label.Location = new System.Drawing.Point(132, 182);
            this.Seen_label.Name = "Seen_label";
            this.Seen_label.Size = new System.Drawing.Size(315, 13);
            this.Seen_label.TabIndex = 11;
            this.Seen_label.Text = "Адресс еще не появлялся в сети (вероятно еще не создан?)";
            // 
            // CheckAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 207);
            this.Controls.Add(this.Seen_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstSeen_textBox);
            this.Controls.Add(this.Balance_textBox);
            this.Controls.Add(this.Send_textBox);
            this.Controls.Add(this.Received_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.PublicAddress_textBox);
            this.Controls.Add(this.label1);
            this.Name = "CheckAddressForm";
            this.Text = "Проверить конкретный адрес";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckAddressForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PublicAddress_textBox;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Received_textBox;
        private System.Windows.Forms.TextBox Send_textBox;
        private System.Windows.Forms.TextBox Balance_textBox;
        private System.Windows.Forms.TextBox FirstSeen_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Seen_label;
    }
}