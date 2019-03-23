using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;//используемая библиотека
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_progect
{
    public partial class Vhod : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Sklad.mdb";
        private OleDbConnection myConnection;

        public Vhod()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();//открытие доступа
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            command.CommandText = "SELECT * FROM Autorithation where Login='"+ textBox1.Text+ "'and Parol='"+ textBox2.Text+ "'";
            OleDbDataReader reader = command.ExecuteReader();
            int z = 0;
            while (reader.Read())
            {
                z++;
            }
            if (z == 1)
            {
               // MessageBox.Show("Супер");
                Gm new1 = new Gm();
                new1.Show();
                this.Close();
            }
          else
            {
                MessageBox.Show("Неправильный логин или пароль ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg new1 = new Reg();
            new1.Show();

            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
