using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_progect
{
    public partial class Sklad : Form
    {
        public Sklad()
        {
         
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Gm new1 = new Gm();
            new1.Show();
            
            /*Vhod new1 = new Vhod();
            new1.Show();*/
            Hide();
        }

     

        private void label2_Click(object sender, EventArgs e)
        {
            Prava newForm = new Prava();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Parent = label1;
            label2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
