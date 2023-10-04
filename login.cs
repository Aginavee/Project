using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.cs
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "N")
            {
                if (txtpass.Text == "n")
                {
                    MessageBox.Show("Login Successfully ! ");
                    home hom = new home();
                    hom.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
            }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }

