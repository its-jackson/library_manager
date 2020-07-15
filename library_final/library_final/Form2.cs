using System.Windows.Forms;

namespace library_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* creds to this guy for teaching me how to do this:
             * www.stackoverflow.com/questions/4580263/how-to-open-in-default-browser-in-c-sharp
             */
            System.Diagnostics.Process.Start("https://jacksonjohnson.tech");
        }
    }
}
