using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDB
{
    public partial class Search : Form
    {

        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Petryk\source\repos\LibraryDB\LibraryDB\LibraryTestBD.mdf;Integrated Security=True";
        SqlConnection connection;
        string type = null;
        public Search()
        {
            InitializeComponent();

            try
            {
                listView1.View = View.Details;
                this.listView1.Items.Clear();
                connection = new SqlConnection(str);
                connection.Open();
                string select = "SELECT * FROM [Library]";
                SqlCommand view = new SqlCommand(select, connection);
                SqlDataReader dr = view.ExecuteReader();
               

                columnHeader2.Text = "Title";
                columnHeader3.Text = "Author";
                columnHeader4.Text = "Year";
                columnHeader5.Text = "Genre";


                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem();

                    item.SubItems.Add(dr.GetValue(1).ToString());
                    item.SubItems.Add(dr.GetValue(2).ToString());
                    item.SubItems.Add(dr.GetValue(3).ToString());
                    item.SubItems.Add(dr.GetValue(4).ToString());

                    listView1.Items.Add(item);



                }
                dr.Close();
                connection.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void titleRadio_CheckedChanged(object sender, EventArgs e)
        {
            type = "Title";
        }

        private void AuthorRadio_CheckedChanged(object sender, EventArgs e)
        {
            type = "Author";

        }

        private void yearRadio_CheckedChanged(object sender, EventArgs e)
        {
            type = "Year";
        }

        private void genreRadio_CheckedChanged(object sender, EventArgs e)
        {
            type = "Genre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string select;
                this.listView1.Items.Clear();
                if (textBox1.Text == "")  select = "SELECT * FROM [Library]"; 
                else select = "SELECT * FROM [Library] where "+type+"='"+textBox1.Text+"'";

                connection.Open();
                SqlCommand view = new SqlCommand(select, connection);
                SqlDataReader dr = view.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem();

                    item.SubItems.Add(dr.GetValue(1).ToString());
                    item.SubItems.Add(dr.GetValue(2).ToString());
                    item.SubItems.Add(dr.GetValue(3).ToString());
                    item.SubItems.Add(dr.GetValue(4).ToString());

                    listView1.Items.Add(item);



                }
                dr.Close();
                connection.Close();

            }
            catch (SqlException x)
            {

                Console.WriteLine($"Error {x.Message}");
            }
        }
    }
}
