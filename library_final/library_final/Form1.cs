using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace library_final
{
    public partial class Form1 : Form
    {
        static string azure = "Server=tcp:semester2.database.windows.net,1433;Database=net;User ID=jackson200337556;Password=Johnson9;Trusted_Connection=False;Encrypt=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT first_name, last_name, phone_number, email, home_address ");
                    sb.Append("FROM library_members;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            listView1.Items.Clear();
                            while (reader.Read())
                            {
                                StringBuilder formatString = new StringBuilder();
                                formatString.Append(reader.GetString(0) + " ");
                                formatString.Append(reader.GetString(1) + " ");
                                formatString.Append(reader.GetString(2) + " ");
                                formatString.Append(reader.GetString(3) + " ");
                                formatString.Append(reader.GetString(4) + " ");
                                listView1.Items.Add(formatString.ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void viewBookRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT book_name, book_author, start_date, return_date ");
                    sb.Append("FROM library_book_rentals;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            listView2.Items.Clear();
                            while (reader.Read())
                            {
                                StringBuilder formatString = new StringBuilder();
                                formatString.Append(reader.GetString(0) + " ");
                                formatString.Append(reader.GetString(1) + " ");
                                formatString.Append(reader.GetDateTime(2) + " ");
                                formatString.Append(reader.GetDateTime(3) + " ");

                                listView2.Items.Add(formatString.ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(azure))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT book_name, book_author, book_genre ");
                    sb.Append("FROM library;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            listView3.Items.Clear();
                            while (reader.Read())
                            {
                                StringBuilder formatString = new StringBuilder();
                                formatString.Append(reader.GetString(0) + " ");
                                formatString.Append(reader.GetString(1) + " ");
                                formatString.Append(reader.GetString(2) + " ");
                                listView3.Items.Add(formatString.ToString());
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void insertNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void updateMemberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void rentABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void updateBookRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void deleteBookRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void addABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void updateABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void removeABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* creds to this guy for teaching me how to do this:
            * www.stackoverflow.com/questions/4580263/how-to-open-in-default-browser-in-c-sharp
            */
            System.Diagnostics.Process.Start("https://github.com");
        }
    }
}