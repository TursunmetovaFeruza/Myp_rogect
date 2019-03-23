using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//используемая библиотека
using System.Collections;

namespace my_progect
{
    public partial class Spisok : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|Sklad.mdb";
        //   public static string connectString = "Provider=Microsoft.ACE.OLEDB.4.0;Data Sourse=CKL.accdb";
        /* Provider=Microsoft.Jet.OLEDB.4.0; - имя поставщика данных, через который будет происходить доступ
Data Source=|DataDirectory|Sklad.mdb" – путь к базе данных и имя файла
*/
        private OleDbConnection myConnection;
        public Spisok()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();//открытие доступа
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        public void firstrunpos()
        {
            
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string query = "SELECT Tovar.Name as Товар, Category.NameCat as Категория, Proizvoditel.NameProiz as Бренд, Postavshik.NamePost as Поставщик, EdIzVchem.NameVchem as Единица, Ves.NameEdIzVes as Вес, Tovar.Kolichestvo as Количество FROM((((Tovar INNER JOIN Category ON Tovar.NumCat = Category.idCat) INNER JOIN Postavshik ON Tovar.NumPostav = Postavshik.idPost) INNER JOIN Proizvoditel ON Tovar.NumProizv = Proizvoditel.idProiz) INNER JOIN EdIzVchem ON Tovar.NumEdIzmerVchem = EdIzVchem.idEdIzVchem) INNER JOIN Ves ON Tovar.NumEdIzmerVes = Ves.idVes ORDER BY Tovar.Name";
            command.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dt = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            da.Fill(dt);//получение данных
            dataGridView1.DataSource = dt;// вывод на гридсетке
            string name = "SELECT DISTINCT Tovar.Name FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat ORDER BY Tovar.Name";
            command.CommandText = name;
            OleDbDataReader read = command.ExecuteReader();
            while (read.Read())

            {
                tn.Items.Add(read[0].ToString());
            }
            read.Close();
            string cat= "SELECT DISTINCT  Category.NameCat  FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat ORDER BY Category.NameCat";
            command.CommandText = cat;
            OleDbDataReader read1 = command.ExecuteReader();
           
            while (read1.Read()) { 
                categ.Items.Add(read1[0].ToString());
        }
            read1.Close();
            string pr = "SELECT DISTINCT Proizvoditel.NameProiz  FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat ORDER BY Proizvoditel.NameProiz";
            command.CommandText = pr;
              OleDbDataReader read2 = command.ExecuteReader(); 
              while (read2.Read())
             {
                 proiz.Items.Add(read2[0].ToString());
             }
            read2.Close();
            string pos = "SELECT DISTINCT Postavshik.NamePost  FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat ORDER BY Postavshik.NamePost";
            command.CommandText = pos;
              OleDbDataReader read3 = command.ExecuteReader();
             while (read3.Read())
             {
                 post.Items.Add(read3[0].ToString());
             }
            read3.Close();
            //  myConnection.Close();


        }
        public void changepos()
        {
            dataGridView2.Rows.Clear();
            ArrayList row = new ArrayList();
            var count=0; var count1 = 0; var count2 = 0; var count3 = 0;
            if (categ.Text == "") {  count = categ.Items.Count; } else { count = 1; }
            if (tn.Text == "") { count1 = tn.Items.Count; } else { count1 = 1; }
            if (proiz.Text == "") { count2 = proiz.Items.Count; } else { count2 = 1; }
            if (post.Text == "") { count3 = post.Items.Count; } else { count3 = 1; }
           
            Console.WriteLine(count);
            row.Add(count1);
            row.Add(count);
            row.Add(count2);
            row.Add(count3);
            dataGridView2.Rows.Add(row.ToArray());

        }
        private void Spisok_Load(object sender, EventArgs e)
        {
            firstrunpos();
            changepos();
        }

        private void Spisok_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConnection.Close();
        }

        private void tn_SelectedIndexChanged(object sender, EventArgs e)
        {
            post.Items.Clear();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string pos = "SELECT DISTINCT Postavshik.NamePost FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'  and Tovar.Name LIKE '" + tn.Text + "%' and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Postavshik.NamePost";
            command.CommandText = pos;
            OleDbDataReader read3 = command.ExecuteReader();

            while (read3.Read())

            {
                post.Items.Add(read3[0].ToString());
            }
            //  myConnection.Close();
            read3.Close();
            categ.Items.Clear();
            string cat = "SELECT DISTINCT Category.NameCat FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat    WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'and Tovar.Name LIKE '" + tn.Text + "%' ORDER BY Category.NameCat";
            command.CommandText = cat;
            OleDbDataReader read = command.ExecuteReader();

            while (read.Read())

            {
                categ.Items.Add(read[0].ToString());
            }
            read.Close();
            proiz.Items.Clear();
            string proz = "SELECT DISTINCT Proizvoditel.NameProiz FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Tovar.Name LIKE '" + tn.Text + "%' and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Proizvoditel.NameProiz";
            command.CommandText = proz;
            OleDbDataReader read2 = command.ExecuteReader();

            while (read2.Read())

            {
                proiz.Items.Add(read2[0].ToString());

            }
            //  myConnection.Close();
            read2.Close();




        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {
            post.Items.Clear();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string pos = "SELECT DISTINCT Postavshik.NamePost FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'  and Tovar.Name LIKE '" + tn.Text + "%' and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Postavshik.NamePost";
            command.CommandText = pos;
            OleDbDataReader read3 = command.ExecuteReader();

            while (read3.Read())

            {
                post.Items.Add(read3[0].ToString());
            }
            //  myConnection.Close();
            read3.Close();
            tn.Items.Clear();
            string name = "SELECT DISTINCT Tovar.Name FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Tovar.Name";
            command.CommandText = name;
            OleDbDataReader read1 = command.ExecuteReader();

            while (read1.Read())

            {
                tn.Items.Add(read1[0].ToString());
            }
            //  myConnection.Close();
            read1.Close();
            proiz.Items.Clear();
            string proz = "SELECT DISTINCT Proizvoditel.NameProiz FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Tovar.Name LIKE '" + tn.Text + "%' and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Proizvoditel.NameProiz";
            command.CommandText = proz;
            OleDbDataReader read2 = command.ExecuteReader();

            while (read2.Read())

            {
                proiz.Items.Add(read2[0].ToString());

            }
            //  myConnection.Close();
            read2.Close();



        }

        private void proiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            post.Items.Clear();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string pos = "SELECT DISTINCT Postavshik.NamePost FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'  and Tovar.Name LIKE '" + tn.Text + "%' and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Postavshik.NamePost";
            command.CommandText = pos;
            OleDbDataReader read3 = command.ExecuteReader();

            while (read3.Read())

            {
                post.Items.Add(read3[0].ToString());
            }
            //  myConnection.Close();
            read3.Close();
            categ.Items.Clear();
            string cat = "SELECT DISTINCT Category.NameCat FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat    WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'and Tovar.Name LIKE '" + tn.Text + "%' ORDER BY Category.NameCat";
            command.CommandText = cat;
            OleDbDataReader read = command.ExecuteReader();

            while (read.Read())

            {
                categ.Items.Add(read[0].ToString());
            }
            read.Close();
            tn.Items.Clear();
            string name = "SELECT DISTINCT Tovar.Name FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Tovar.Name";
            command.CommandText = name;
            OleDbDataReader read1 = command.ExecuteReader();

            while (read1.Read())

            {
                tn.Items.Add(read1[0].ToString());
            }
            //  myConnection.Close();
            read1.Close();

        }

        private void post_SelectedIndexChanged(object sender, EventArgs e)
        {
            proiz.Items.Clear();

            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string proz = "SELECT DISTINCT Proizvoditel.NameProiz FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Tovar.Name LIKE '" + tn.Text + "%' and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Proizvoditel.NameProiz";
            command.CommandText = proz;
            OleDbDataReader read2 = command.ExecuteReader();

            while (read2.Read())

            {
                proiz.Items.Add(read2[0].ToString());

            }
            //  myConnection.Close();
            read2.Close();
            categ.Items.Clear();
            string cat = "SELECT DISTINCT Category.NameCat FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat    WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'and Tovar.Name LIKE '" + tn.Text + "%' ORDER BY Category.NameCat";
            command.CommandText = cat;
            OleDbDataReader read = command.ExecuteReader();

            while (read.Read())

            {
                categ.Items.Add(read[0].ToString());
            }
            read.Close();
            tn.Items.Clear();
            string name = "SELECT DISTINCT Tovar.Name FROM Category INNER JOIN(Postavshik INNER JOIN (Proizvoditel INNER JOIN Tovar ON Proizvoditel.idProiz = Tovar.NumProizv) ON Postavshik.idPost = Tovar.NumPostav) ON Category.idCat = Tovar.NumCat  WHERE Postavshik.NamePost LIKE '" + post.Text + "%'  and Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'and Category.NameCat LIKE '" + categ.Text + "%' ORDER BY Tovar.Name";
            command.CommandText = name;
            OleDbDataReader read1 = command.ExecuteReader();

            while (read1.Read())

            {
                tn.Items.Add(read1[0].ToString());
            }
            //  myConnection.Close();
            read1.Close();
        }

        private void set_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            string query = "SELECT Tovar.Name as Товар, Category.NameCat as Категория, Proizvoditel.NameProiz as Бренд, Postavshik.NamePost as Поставщик, EdIzVchem.NameVchem as Единица, Ves.NameEdIzVes as Вес, Tovar.Kolichestvo as Количество FROM((((Tovar INNER JOIN Category ON Tovar.NumCat = Category.idCat) INNER JOIN Postavshik ON Tovar.NumPostav = Postavshik.idPost) INNER JOIN Proizvoditel ON Tovar.NumProizv = Proizvoditel.idProiz) INNER JOIN EdIzVchem ON Tovar.NumEdIzmerVchem = EdIzVchem.idEdIzVchem) INNER JOIN Ves ON Tovar.NumEdIzmerVes = Ves.idVes WHERE Postavshik.NamePost LIKE '" + post.Text + "%' and Category.NameCat LIKE '" + categ.Text + "%' and Proizvoditel.NameProiz LIKE '" + proiz.Text + "%'and Tovar.Name LIKE '" + tn.Text + "%'  ORDER BY Tovar.Name";
            command.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(command);// набор команд данных и подключение к базе данных, которые используются для заполнения dataGridView1
            DataTable dt = new DataTable();//Объект DataTable для заполнения записями и, если это необходимо, схемы.
            da.Fill(dt);//получение данных
            dataGridView1.DataSource = dt;// вывод на гридсетке
            changepos();

        }

        private void def_Click(object sender, EventArgs e)
        {
            categ.Text = "";
            tn.Text = "";
            proiz.Text = "";
            post.Text = "";
            categ.Items.Clear();
            tn.Items.Clear();
            proiz.Items.Clear();
            post.Items.Clear();
            firstrunpos();
            changepos();
        }

        private void past_Click(object sender, EventArgs e)
        {
           
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[2, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
           
            xlWorkSheet.Cells[1, 2] = "Товар";
            xlWorkSheet.Cells[1, 3] = "Категория";
            xlWorkSheet.Cells[1, 4] = "Бренд";
            xlWorkSheet.Cells[1, 5] = "Поставщик";
            xlWorkSheet.Cells[1, 6] = "Единица";
            xlWorkSheet.Cells[1, 7] = "Вес";
            xlWorkSheet.Cells[1, 8] = "Количесттво";

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}