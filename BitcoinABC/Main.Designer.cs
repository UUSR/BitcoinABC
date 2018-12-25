namespace BitcoinABC
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проверкаАдресаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертерАдресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генераторАдресовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проверкаАдресаToolStripMenuItem,
            this.конвертерАдресовToolStripMenuItem,
            this.генераторАдресовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проверкаАдресаToolStripMenuItem
            // 
            this.проверкаАдресаToolStripMenuItem.Name = "проверкаАдресаToolStripMenuItem";
            this.проверкаАдресаToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.проверкаАдресаToolStripMenuItem.Text = "Проверка адреса";
            this.проверкаАдресаToolStripMenuItem.Click += new System.EventHandler(this.проверкаАдресаToolStripMenuItem_Click);
            // 
            // конвертерАдресовToolStripMenuItem
            // 
            this.конвертерАдресовToolStripMenuItem.Name = "конвертерАдресовToolStripMenuItem";
            this.конвертерАдресовToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.конвертерАдресовToolStripMenuItem.Text = "Конвертер адресов";
            this.конвертерАдресовToolStripMenuItem.Click += new System.EventHandler(this.конвертерАдресовToolStripMenuItem_Click);
            // 
            // генераторАдресовToolStripMenuItem
            // 
            this.генераторАдресовToolStripMenuItem.Name = "генераторАдресовToolStripMenuItem";
            this.генераторАдресовToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.генераторАдресовToolStripMenuItem.Text = "Генератор адресов";
            this.генераторАдресовToolStripMenuItem.Click += new System.EventHandler(this.генераторАдресовToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "BitcoinABC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проверкаАдресаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конвертерАдресовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генераторАдресовToolStripMenuItem;
    }
}

