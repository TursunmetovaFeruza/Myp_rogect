using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;//используемая библиотека
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_progect
{
    public partial class Spravochnik : Form
    {
        int i= 0; 
        string q;int t = 0;
        //присоединение к базе данных
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Sklad.mdb";
        //   public static string connectString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Sourse=CKL.accdb";
        /* Provider=Microsoft.Jet.OLEDB.4.0; - имя поставщика данных, через который будет происходить доступ
Data Source=|DataDirectory|Sklad.mdb" – путь к базе данных и имя файла
*/

        private OleDbConnection myConnection;
        public Spravochnik()
        {
            InitializeComponent();
            //доступ к базе данных
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();//открытие доступа
        }


        private void Spravochnik_Load(object sender, EventArgs e)
        {

            // myConnection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string query = "SELECT Name FROM Tovar ORDER BY Tovar.Name";// выбираем необходимую таблицу и поле
            command.CommandText = query;
            command.ExecuteNonQuery();
            OleDbDataAdapter df = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dd = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            df.Fill(dd);//получение данных
            foreach (DataRow dr in dd.Rows)
            {
                name_list.Items.Add(dr["Name"].ToString());
            }

            string cat = "SELECT NameCat FROM Category";
            command.CommandText = cat;
            OleDbDataReader read = command.ExecuteReader();
            while (read.Read())

            {
                categ.Items.Add(read[0].ToString());

            }
            //  myConnection.Close();
            read.Close();

            // "SELECT Proizvoditel.NameProiz AS Производитель, Postavshik.NamePost AS Поставщик FROM Postavshik INNER JOIN Proizvoditel ON Postavshik.idPost = Proizvoditel.NumPost";
            command.Connection = myConnection;
            //вводим запрос, котрый был создан на 5 вопросе он соединяет 2 таблицы 
            string tov = "SELECT Proizvoditel.NameProiz AS Производитель, Postavshik.NamePost AS Поставщик FROM Proizvoditel INNER JOIN Postavshik ON Proizvoditel.NumPost = Postavshik.idPost";
            command.CommandText = tov;//Возвращает или задает текст команды для выполнения в источнике данных.
            OleDbDataAdapter da = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dt = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            da.Fill(dt);//получение данных
            dataGridView1.DataSource = dt;// вывод на гридсетке

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // На закрытия формы мы закрываем доступ к нашей базе данных
        private void Spravochnik_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dob_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            categ.Enabled = true;
            save.Enabled = true;
            otm.Enabled = true;
            tn.Enabled = false;
            name_list.Enabled = false;
            izm.Enabled = false;
            delate.Enabled = false;
            Close.Enabled = false;
            name.Text = "";
            categ.Text = "";

            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            command.CommandText = "SELECT Tovar.idTovar FROM Tovar INNER JOIN Category ON Tovar.NumCat = Category.idCat where Name ='" + name.Text + "' and NameCat ='" + categ.Text + "' ";
            command.ExecuteNonQuery();
           
            OleDbDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                q = read["idTovar"].ToString();
                t = Int16.Parse(q);
            }
            i = 1;
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string cat = "SELECT Proizvoditel.NameProiz AS Производитель, Postavshik.NamePost AS Поставщик FROM ((Tovar INNER JOIN Proizvoditel ON Tovar.NumProizv = Proizvoditel.idProiz) INNER JOIN Postavshik ON Proizvoditel.NumPost = Postavshik.idPost) INNER JOIN Category ON Tovar.NumCat = Category.idCat  WHERE NameCat ='" + categ.Text + "'and Name ='" + name.Text + "'";
            command.CommandText = cat;
            OleDbDataAdapter da = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dt = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            da.Fill(dt);//получение данных
            dataGridView1.DataSource = dt;// вывод на гридсетке
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string cat = "SELECT Proizvoditel.NameProiz AS Производитель, Postavshik.NamePost AS Поставщик FROM ((Tovar INNER JOIN Proizvoditel ON Tovar.NumProizv = Proizvoditel.idProiz) INNER JOIN Postavshik ON Proizvoditel.NumPost = Postavshik.idPost) INNER JOIN Category ON Tovar.NumCat = Category.idCat  WHERE Name ='" + name.Text + "' and  NameCat ='" + categ.Text + "'";
            command.CommandText = cat;
            OleDbDataAdapter da = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dt = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            da.Fill(dt);//получение данных
            dataGridView1.DataSource = dt;// вывод на гридсетке

        }

        private void tn_TextChanged(object sender, EventArgs e)
        {
            name.Enabled = true;
            categ.Enabled = true;
            save.Enabled = true;
            otm.Enabled = true;
            name.Enabled = false;
            categ.Enabled = false;
            save.Enabled = false;
            otm.Enabled = false;
            name_list.SelectedIndex = name_list.FindString(tn.Text); 
           


        }

        private void name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
          
     }

        private void name_list_Click(object sender, EventArgs e)
        {
            name.Enabled = false;
            categ.Enabled = false;
            save.Enabled = false;
            otm.Enabled = false;
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;
                command.CommandText = "SELECT Tovar.Name, Category.NameCat FROM Tovar INNER JOIN Category ON Tovar.NumCat = Category.idCat WHERE Name= '" + name_list.SelectedItem.ToString() + "'";// выбираем необходимую таблицу и поле
                command.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
                DataTable dt = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
                da.Fill(dt);//получение данных
                foreach (DataRow dr in dt.Rows)
                {
                    name.Text = dr["Name"].ToString();
                    categ.Text = dr["NameCat"].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Нет такого товара");
            }
        }

        private void izm_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            categ.Enabled = true;
            save.Enabled = true;
            otm.Enabled = true;
            tn.Enabled = false;
            name_list.Enabled = false;
            dob.Enabled = false;
            delate.Enabled = false;
            Close.Enabled = false;

            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            command.CommandText = "SELECT Tovar.idTovar FROM Tovar INNER JOIN Category ON Tovar.NumCat = Category.idCat where Name ='" + name.Text + "' and NameCat ='" + categ.Text + "' ";
            command.ExecuteNonQuery();
            int z = 0;
            OleDbDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                q = read["idTovar"].ToString();

                t = Int16.Parse(q);
              //  MessageBox.Show(t.ToString());
                z = z + 1;
            }
            //  myConnection.Close();
           
            if (z == 1)
            {
                MessageBox.Show("Такой товар существует. Вы можете внести изменеия и сохранить");
            }
            if (z == 0)
            {
                MessageBox.Show("Такого товара нет.");
                t = 0;
            }
            i = 0;
      
        }

        private void delate_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
            categ.Enabled = true;
            save.Enabled = true;
            otm.Enabled = true;
            tn.Enabled = false;
            name_list.Enabled = false;
            dob.Enabled = false;
           izm.Enabled = false;
            Close.Enabled = false;

            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            command.CommandText = "SELECT Tovar.idTovar FROM Tovar INNER JOIN Category ON Tovar.NumCat = Category.idCat where Name ='" + name.Text + "' and NameCat ='" + categ.Text + "' ";
            command.ExecuteNonQuery();
            int z = 0;
            OleDbDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                q = read["idTovar"].ToString();

                t = Int16.Parse(q);
                 
                z = z + 1;
            }
            //  myConnection.Close();

            if (z == 1)
            {
                MessageBox.Show("Такой товар существует. Вы можете его удалить");
            }
            if (z == 0)
            {
                MessageBox.Show("Такого товара нет.");
                t = 0;
            }
            i = 2;
        }

        private void save_Click(object sender, EventArgs e)
        {
            int z = 0;
            OleDbCommand comman = new OleDbCommand();
            comman.Connection = myConnection;
            comman.CommandText = "select Name from Tovar  where Name ='" + name.Text + "'";
            comman.ExecuteNonQuery();
            OleDbDataReader read = comman.ExecuteReader();
            while (read.Read())
            {
                z = z + 1;
            }
       
         
            int c=0;
            if (categ.Text== "детское питание")
            {
                c=c+2;
            }
            if (categ.Text== "продукты питания")
            {
                c = c+1;
            }
            if (i == 1)
            {
                
                if (z == 1)
                {
                    MessageBox.Show("Такой товар уже существует");
                }
                if (z == 0)
                {
                    try
                    {
                        OleDbCommand comand = new OleDbCommand();
                        comand.Connection = myConnection;
                        comand.CommandText = "insert into Tovar (Name, NumCat)  values ('" + name.Text + "','" + c + "')";
                        comand.ExecuteNonQuery();
                        MessageBox.Show("Товар  сохранен");
                    }
                    catch
                    {
                        MessageBox.Show("Товар не сохранен");
                    }
                }
              
            }
           if (i == 0)
            {
                if (t > 0)
                {
                    try
                    {
                        OleDbCommand commant = new OleDbCommand();
                        commant.Connection = myConnection;
                        commant.CommandText = "UPDATE  Tovar SET  Name ='" + name.Text + "' , NumCat='" + c + "' WHERE idTovar=" + t + " ";
                        commant.ExecuteNonQuery();
                        MessageBox.Show("Товар  сохранен");
                    }
                    catch
                    {
                        MessageBox.Show("Товар не изменен");
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("Товар не изменен");
                }
            }
            if (i == 2)
            {
                if (t > 0)
                {
                    try
                    {
                        OleDbCommand com = new OleDbCommand();
                        com.Connection = myConnection;
                        com.CommandText = "DELETE  FROM Tovar WHERE idTovar=" + t + " ";
                        com.ExecuteNonQuery();
                        MessageBox.Show("Товар удален");
                    }

                    catch
                    {
                        MessageBox.Show("Товар не удален");
                    }
                }
                if (t == 0)
                {
                    MessageBox.Show("Товар не удален 1");
                }

            }
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            name_list.Items.Clear();
            string query = "SELECT Name FROM Tovar ORDER BY Tovar.Name";// выбираем необходимую таблицу и поле
            command.CommandText = query;
            command.ExecuteNonQuery();
            OleDbDataAdapter df = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dd = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            df.Fill(dd);//получение данных
            foreach (DataRow dr in dd.Rows)
            {
                name_list.Items.Add(dr["Name"].ToString());
            }
            name.Enabled = false;
            categ.Enabled = false;
            save.Enabled = false;
            delate.Enabled = true;
            izm.Enabled = true;
            dob.Enabled = true;
            otm.Enabled = false;
            tn.Enabled = true;
            name_list.Enabled = true;
        }

        private void otm_Click(object sender, EventArgs e)
        {
            name.Enabled = false;
            categ.Enabled = false;
            save.Enabled = false;
            delate.Enabled = true;
            izm.Enabled = true;
            dob.Enabled = true;
            otm.Enabled = false;
            tn.Enabled = true; 
            name_list.Enabled = true;
            OleDbCommand comman = new OleDbCommand();
            comman.Connection = myConnection;
           
            
            string query = "SELECT Tovar.Name, Category.NameCat FROM Tovar INNER JOIN Category ON Tovar.NumCat = Category.idCat WHERE idTovar = "+t+" ";// выбираем необходимую таблицу и поле
            comman.CommandText = query;
            comman.ExecuteNonQuery();
            OleDbDataAdapter df = new OleDbDataAdapter(comman);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dd = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            df.Fill(dd);//получение данных
            foreach (DataRow dr in dd.Rows)
            {
                name.Text = dr["Name"].ToString();
                categ.Text = dr["NameCat"].ToString();
            }
        }
    }
}
