using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";

            try
            {
                string bookName = textBox1.Text;
                string bookNameConfirm = textBox2.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    if (bookName == bookNameConfirm)
                    {
                        sb.Append("DELETE FROM library WHERE book_name = @bookName;");
                        string sql = sb.ToString();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@bookName", bookName);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Book Deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Book names entered do not match.");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
