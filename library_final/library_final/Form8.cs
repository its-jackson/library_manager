using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";
            try
            {
                string serialID = textBox1.Text;
                string serialIDConfirm = textBox2.Text;

                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();

                    if (serialID == serialIDConfirm)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("DELETE FROM library_book_rentals WHERE serial_id = @serialID;");
                        string sql = sb.ToString();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@serialID", serialID);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Rental Deleted!");
                    }
                    else
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        MessageBox.Show("Serial id entered doesnt match.");
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
