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
    public partial class AddForm : Form
    {
        string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Petryk\source\repos\LibraryDB\LibraryDB\LibraryTestBD.mdf;Integrated Security=True";
        SqlConnection connection;
        
        public AddForm()
        {
            InitializeComponent();
            List<string> genre = new List<string>();
            genre.Add("Science fiction");
            genre.Add("Satire");
            genre.Add("Drama");
            genre.Add("Adventure");
            genre.Add("Romance");
            genre.Add("Mystery");
            genre.Add("Horror");
            genre.Add("Self help");
            genre.Add("Health");
            genre.Add("Guide");
            genre.Add("Travel");
            genre.Add("Children's");
            genre.Add("Religion");
            genre.Add("Science");
            genre.Add("History");
            genre.Add("Math");
            genre.Add("Anthology");
            genre.Add("Poetry");
            genre.Add("Encyclopedias");
            genre.Add("Dictionaries");
            genre.Add("Comics");
            genre.Add("Art");
            genre.Add("Cookbooks");
            genre.Add("Diaries");
            genre.Add("Journals");
            genre.Add("Prayer books");
            genre.Add("Series");
            genre.Add("Trilogy");
            genre.Add("Biographies");
            genre.Add("Autobiographies");
            genre.Add("Fantasy");
            GenreComboBox1.DataSource = genre;
            GenreComboBox1.SelectedItem="Science";

            connection = new SqlConnection(str);
            connection.Open();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string title = TitleTextBox.Text.ToString();
                string author = AuthorTextBox.Text.ToString();
                int year = int.Parse(YearNumericUpDown.Value.ToString());
                string genre = GenreComboBox1.Text.ToString();

            try
            {
                
                string insert = "INSERT INTO Library (Title,Author, Year, Genre) VALUES('" + title + "','" + author + "'," + year + ",'" + genre + "')";
                SqlCommand sqlCommand = new SqlCommand(insert, connection);
                sqlCommand.ExecuteNonQuery();
               
            }
            catch (SqlException x)
            {

                MessageBox.Show(x.ToString());
            }
            connection.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
