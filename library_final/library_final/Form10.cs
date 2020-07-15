using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";

            try
            {
                string name = textBox1.Text;

                string newName = textBox2.Text;

                string author = textBox3.Text;

                string genre = textBox4.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE library SET book_name = @newName, book_author = @author, book_genre = @genre WHERE book_name = @name;");
                    string sql = sb.ToString();

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@author", author);
                    command.Parameters.AddWithValue("@genre", genre);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@book_name", name);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Book Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
