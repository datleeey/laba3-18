namespace laba3_18
{
    partial class Form1
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
            this.масивиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірнийМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірнийМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масивиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // масивиToolStripMenuItem
            // 
            this.масивиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірнийМасивToolStripMenuItem,
            this.двовимірнийМасивToolStripMenuItem});
            this.масивиToolStripMenuItem.Name = "масивиToolStripMenuItem";
            this.масивиToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.масивиToolStripMenuItem.Text = " Масиви";
            this.масивиToolStripMenuItem.Click += new System.EventHandler(this.масивиToolStripMenuItem_Click);
            // 
            // одновимірнийМасивToolStripMenuItem
            // 
            this.одновимірнийМасивToolStripMenuItem.Name = "одновимірнийМасивToolStripMenuItem";
            this.одновимірнийМасивToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.одновимірнийМасивToolStripMenuItem.Text = "Одновимірний масив";
            this.одновимірнийМасивToolStripMenuItem.Click += new System.EventHandler(this.одновимірнийМасивToolStripMenuItem_Click);
            // 
            // двовимірнийМасивToolStripMenuItem
            // 
            this.двовимірнийМасивToolStripMenuItem.Name = "двовимірнийМасивToolStripMenuItem";
            this.двовимірнийМасивToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.двовимірнийМасивToolStripMenuItem.Text = "Двовимірний масив";
            this.двовимірнийМасивToolStripMenuItem.Click += new System.EventHandler(this.двовимірнийМасивToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem масивиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одновимірнийМасивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірнийМасивToolStripMenuItem;
    }
}

