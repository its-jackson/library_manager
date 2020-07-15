using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";

            try
            {
                string email = textBox1.Text;

                string newFName = textBox2.Text;

                string newLName = textBox3.Text;

                string newPhone = textBox4.Text;

                string newEmail = textBox5.Text;

                string newLocation = textBox6.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE library_members SET first_name = @newFName, last_name = @newLName, phone_number = @newPhone, email = @newEmail, home_address = @newLocation WHERE email = @email");
                    string sql = sb.ToString();

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@newFName", textBox2.Text);
                    command.Parameters.AddWithValue("@newLName", textBox3.Text);
                    command.Parameters.AddWithValue("@newPhone", textBox4.Text);
                    command.Parameters.AddWithValue("@newEmail", textBox5.Text);
                    command.Parameters.AddWithValue("@newLocation", textBox6.Text);
                    command.Parameters.AddWithValue("@email", textBox1.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Member Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
