namespace my_progect
{
    partial class Spravochnik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spravochnik));
            this.name = new System.Windows.Forms.TextBox();
            this.tovarname = new System.Windows.Forms.Label();
            this.post = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Button();
            this.izm = new System.Windows.Forms.Button();
            this.delate = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.otm = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.categ = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.name_list = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.proizvoditelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).BeginInit();
            this.navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(379, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(154, 20);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // tovarname
            // 
            this.tovarname.AutoSize = true;
            this.tovarname.Location = new System.Drawing.Point(265, 47);
            this.tovarname.Name = "tovarname";
            this.tovarname.Size = new System.Drawing.Size(95, 13);
            this.tovarname.TabIndex = 24;
            this.tovarname.Text = "Название товара";
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(265, 81);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(60, 13);
            this.post.TabIndex = 5;
            this.post.Text = "Категория";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(10, 19);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(109, 23);
            this.dob.TabIndex = 8;
            this.dob.Text = "Добавить";
            this.dob.UseVisualStyleBackColor = true;
            this.dob.Click += new System.EventHandler(this.dob_Click);
            // 
            // izm
            // 
            this.izm.Location = new System.Drawing.Point(10, 63);
            this.izm.Name = "izm";
            this.izm.Size = new System.Drawing.Size(109, 23);
            this.izm.TabIndex = 9;
            this.izm.Text = "Изменить";
            this.izm.UseVisualStyleBackColor = true;
            this.izm.Click += new System.EventHandler(this.izm_Click);
            // 
            // delate
            // 
            this.delate.Location = new System.Drawing.Point(10, 183);
            this.delate.Name = "delate";
            this.delate.Size = new System.Drawing.Size(109, 23);
            this.delate.TabIndex = 10;
            this.delate.Text = "Удалить";
            this.delate.UseVisualStyleBackColor = true;
            this.delate.Click += new System.EventHandler(this.delate_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(10, 104);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(109, 23);
            this.save.TabIndex = 11;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // otm
            // 
            this.otm.Location = new System.Drawing.Point(10, 142);
            this.otm.Name = "otm";
            this.otm.Size = new System.Drawing.Size(109, 23);
            this.otm.TabIndex = 12;
            this.otm.Text = "Отменить";
            this.otm.UseVisualStyleBackColor = true;
            this.otm.Click += new System.EventHandler(this.otm_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(10, 224);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(109, 23);
            this.Close.TabIndex = 13;
            this.Close.Text = "Выход";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // categ
            // 
            this.categ.FormattingEnabled = true;
            this.categ.Location = new System.Drawing.Point(379, 78);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(154, 21);
            this.categ.TabIndex = 25;
            this.categ.SelectedIndexChanged += new System.EventHandler(this.categ_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(250, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 98);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.vScrollBar2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(233, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 147);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(299, 9);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(18, 132);
            this.vScrollBar2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 132);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.name_list);
            this.groupBox4.Controls.Add(this.vScrollBar1);
            this.groupBox4.Controls.Add(this.tn);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Location = new System.Drawing.Point(15, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 274);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            // 
            // name_list
            // 
            this.name_list.FormattingEnabled = true;
            this.name_list.Location = new System.Drawing.Point(20, 53);
            this.name_list.Name = "name_list";
            this.name_list.Size = new System.Drawing.Size(143, 212);
            this.name_list.TabIndex = 3;
            this.name_list.Click += new System.EventHandler(this.name_list_Click);
            this.name_list.SelectedIndexChanged += new System.EventHandler(this.name_list_SelectedIndexChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(166, 53);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 212);
            this.vScrollBar1.TabIndex = 2;
            // 
            // tn
            // 
            this.tn.Location = new System.Drawing.Point(20, 20);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(163, 20);
            this.tn.TabIndex = 0;
            this.tn.TextChanged += new System.EventHandler(this.tn_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.delate);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.izm);
            this.groupBox1.Controls.Add(this.dob);
            this.groupBox1.Controls.Add(this.Close);
            this.groupBox1.Controls.Add(this.otm);
            this.groupBox1.Location = new System.Drawing.Point(650, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 274);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // navigator
            // 
            this.navigator.AddNewItem = null;
            this.navigator.CountItem = this.bindingNavigatorCountItem;
            this.navigator.DeleteItem = null;
            this.navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.navigator.Location = new System.Drawing.Point(0, 361);
            this.navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.navigator.Name = "navigator";
            this.navigator.PositionItem = this.bindingNavigatorPositionItem;
            this.navigator.Size = new System.Drawing.Size(787, 25);
            this.navigator.TabIndex = 39;
            this.navigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Spravochnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(787, 386);
            this.Controls.Add(this.navigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.categ);
            this.Controls.Add(this.post);
            this.Controls.Add(this.tovarname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.groupBox2);
            this.Name = "Spravochnik";
            this.Text = "Spravochnik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Spravochnik_FormClosed);
            this.Load += new System.EventHandler(this.Spravochnik_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proizvoditelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigator)).EndInit();
            this.navigator.ResumeLayout(false);
            this.navigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label tovarname;
        private System.Windows.Forms.Label post;
        private System.Windows.Forms.Button dob;
        private System.Windows.Forms.Button izm;
        private System.Windows.Forms.Button delate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button otm;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox categ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tn;
       
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ListBox name_list;
     
        private System.Windows.Forms.BindingSource proizvoditelBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.BindingNavigator navigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}