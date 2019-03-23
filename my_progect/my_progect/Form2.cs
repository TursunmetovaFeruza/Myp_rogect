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
    public partial class Gm : Form
    {
        public Gm()
        {
            InitializeComponent();
        }

        private void Spisok_Click(object sender, EventArgs e)
        {

            Spisok newForm = new Spisok();
            newForm.Show();
        }

        private void Spravochnik_Click(object sender, EventArgs e)
        {
           Spravochnik newForm = new Spravochnik();
            newForm.Show();
        }

        private void главнаToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
