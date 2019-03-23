namespace my_progect
{
    partial class Spisok
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
            this.tn = new System.Windows.Forms.ComboBox();
            this.categ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.proiz = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.post = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.past = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.def = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название товара";
            // 
            // tn
            // 
            this.tn.FormattingEnabled = true;
            this.tn.Location = new System.Drawing.Point(42, 343);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(121, 21);
            this.tn.TabIndex = 1;
            this.tn.SelectedIndexChanged += new System.EventHandler(this.tn_SelectedIndexChanged);
            // 
            // categ
            // 
            this.categ.FormattingEnabled = true;
            this.categ.Location = new System.Drawing.Point(199, 343);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(121, 21);
            this.categ.TabIndex = 3;
            this.categ.SelectedIndexChanged += new System.EventHandler(this.categ_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория";
            // 
            // proiz
            // 
            this.proiz.FormattingEnabled = true;
            this.proiz.Location = new System.Drawing.Point(42, 400);
            this.proiz.Name = "proiz";
            this.proiz.Size = new System.Drawing.Size(121, 21);
            this.proiz.TabIndex = 5;
            this.proiz.SelectedIndexChanged += new System.EventHandler(this.proiz_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Бренд";
            // 
            // post
            // 
            this.post.FormattingEnabled = true;
            this.post.Location = new System.Drawing.Point(199, 400);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(121, 21);
            this.post.TabIndex = 7;
            this.post.SelectedIndexChanged += new System.EventHandler(this.post_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поставщик";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(28, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(22, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 201);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(438, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 128);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Снять";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Установить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.past);
            this.groupBox4.Controls.Add(this.exit);
            this.groupBox4.Controls.Add(this.def);
            this.groupBox4.Controls.Add(this.set);
            this.groupBox4.Location = new System.Drawing.Point(438, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 128);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // past
            // 
            this.past.Location = new System.Drawing.Point(29, 81);
            this.past.Name = "past";
            this.past.Size = new System.Drawing.Size(113, 31);
            this.past.TabIndex = 3;
            this.past.Text = "Печать";
            this.past.UseVisualStyleBackColor = true;
            this.past.Click += new System.EventHandler(this.past_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(185, 81);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 31);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(185, 32);
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(113, 31);
            this.def.TabIndex = 1;
            this.def.Text = "Снять";
            this.def.UseVisualStyleBackColor = true;
            this.def.Click += new System.EventHandler(this.def_Click);
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(29, 32);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(113, 31);
            this.set.TabIndex = 0;
            this.set.Text = "Установить";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(28, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(741, 41);
            this.dataGridView2.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            // 
            // Spisok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 452);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.post);
            this.Controls.Add(this.proiz);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.tn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Spisok";
            this.Text = "Spisok";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Spisok_FormClosed);
            this.Load += new System.EventHandler(this.Spisok_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tn;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox proiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox post;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
      
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button def;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEdIzmerVchemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numEdIzmerVesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numProizvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPostavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button past;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}