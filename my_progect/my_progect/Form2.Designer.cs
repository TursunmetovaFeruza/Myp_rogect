namespace my_progect
{
    partial class Gm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Spravochnik = new System.Windows.Forms.ToolStripMenuItem();
            this.Spisok = new System.Windows.Forms.ToolStripMenuItem();
            this.sklad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаToolStripMenuItem
            // 
            this.главнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Spravochnik,
            this.Spisok});
            this.главнаToolStripMenuItem.Name = "главнаToolStripMenuItem";
            this.главнаToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаToolStripMenuItem.Text = "Главная";
            this.главнаToolStripMenuItem.Click += new System.EventHandler(this.главнаToolStripMenuItem_Click);
            // 
            // Spravochnik
            // 
            this.Spravochnik.Name = "Spravochnik";
            this.Spravochnik.Size = new System.Drawing.Size(152, 22);
            this.Spravochnik.Text = "Справочник";
            this.Spravochnik.Click += new System.EventHandler(this.Spravochnik_Click);
            // 
            // Spisok
            // 
            this.Spisok.Name = "Spisok";
            this.Spisok.Size = new System.Drawing.Size(152, 22);
            this.Spisok.Text = "Список";
            this.Spisok.Click += new System.EventHandler(this.Spisok_Click);
            // 
            // sklad
            // 
            this.sklad.AutoSize = true;
            this.sklad.Image = global::my_progect.Properties.Resources.sklad;
            this.sklad.Location = new System.Drawing.Point(-3, 24);
            this.sklad.MaximumSize = new System.Drawing.Size(100, 500);
            this.sklad.MinimumSize = new System.Drawing.Size(500, 500);
            this.sklad.Name = "sklad";
            this.sklad.Padding = new System.Windows.Forms.Padding(10);
            this.sklad.Size = new System.Drawing.Size(500, 500);
            this.sklad.TabIndex = 1;
            // 
            // Gm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.sklad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gm";
            this.Text = "Glavnoe menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Spravochnik;
        private System.Windows.Forms.ToolStripMenuItem Spisok;
        private System.Windows.Forms.Label sklad;
    }
}