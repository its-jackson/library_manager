using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";
            try
            {

                string memberID = textBox1.Text;


                string bookName = textBox2.Text;


                string bookAuthor = textBox3.Text;


                string startDate = textBox4.Text;


                string returnDate = textBox5.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO library_book_rentals (member_id, book_name, book_author, start_date, return_date) VALUES (@memberID, @bookName, @bookAuthor, @startDate, @returnDate)");
                    string sql = sb.ToString();

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@memberID", memberID);
                    command.Parameters.AddWithValue("@bookName", bookName);
                    command.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@returnDate", returnDate);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Book Rental Added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
