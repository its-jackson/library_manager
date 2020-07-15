using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";

            try
            {
                string name = textBox1.Text;

                string author = textBox2.Text;

                string genre = textBox3.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO library (book_name, book_author, book_genre) VALUES (@name, @author, @genre)");
                    string sql = sb.ToString();

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Book Added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
