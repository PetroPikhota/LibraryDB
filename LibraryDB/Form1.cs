using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryDB
{
    public partial class Form1 : Form
    {
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Petryk\source\repos\LibraryDB\LibraryDB\LibraryTestBD.mdf;Integrated Security=True";
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
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
    }
}
