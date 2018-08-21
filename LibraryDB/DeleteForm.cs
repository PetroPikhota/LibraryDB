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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection;
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Petryk\source\repos\LibraryDB\LibraryDB\LibraryTestBD.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
            string part=null;

            if (TitleRadioButton.Enabled == true)
            {
                part = "Title";
            }
            else if (AuthorRadioButton.Enabled == true)
            {
                part = "Author";

            }
            else if (GenreRadioButton.Enabled == true)
            {
                part = "Genre";
            }
            else
            {
                MessageBox.Show("Set witch type you wanna delete");
            }

            if (part != null)
            {
                try
                {
                    string del = "DELETE FROM [Library] where " + part + "='" + textBox1.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(del, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("GJ");
                    sqlConnection.Close();
                    Close();
                }catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
