using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";
            try
            {

                string fName = textBox1.Text;

                string lName = textBox2.Text;

                string phone = textBox3.Text;

                string email = textBox4.Text;

                string location = textBox5.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO library_members (first_name, last_name, phone_number, email, home_address) VALUES (@fname, @lname, @phone, @email, @location)");
                    string sql = sb.ToString();

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@fname", fName);
                    command.Parameters.AddWithValue("@lname", lName);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@location", location);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Member Created!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
