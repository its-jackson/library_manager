using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";
            try
            {
                string email = textBox1.Text;
                string emailConfirm = textBox2.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    if (email == emailConfirm)
                    {
                        sb.Append("DELETE FROM library_members WHERE email = @email;");
                        string sql = sb.ToString();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@email", email);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Member Deleted!");
                    }
                    else
                    {
                        MessageBox.Show("Emails entered do not match.");
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
