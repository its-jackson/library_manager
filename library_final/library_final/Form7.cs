using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";

            try
            {
                string serialID = textBox1.Text;

                string newName = textBox2.Text;

                string newAuthor = textBox3.Text;

                string newStartDate = textBox4.Text;

                string newReturnDate = textBox5.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE library_book_rentals SET book_name = @newName, book_author = @newAuthor, start_date = @newStartDate, return_date = @newReturnDate WHERE serial_id = @serialID;");
                    string sql = sb.ToString();

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@newAuthor", newAuthor);
                    command.Parameters.AddWithValue("@newStartDate", newStartDate);
                    command.Parameters.AddWithValue("@newReturnDate", newReturnDate);
                    command.Parameters.AddWithValue("@serialID", serialID);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Rental Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
