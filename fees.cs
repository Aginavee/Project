using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.cs
{
    public partial class fees : Form
    {
        Applicat app = new Applicat();
        object[] obj;
        public fees()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)

        {
            home h = new home();
            h.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = app.Feeload(int.Parse(txtone.Text));
            txtonename.Text = obj[1].ToString();
            dateone.Text = obj[3].ToString();
            txtonephn.Text = obj[4].ToString();
            txtonedept.Text = obj[5].ToString();
        }

        private void txtone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter st = new StreamWriter("d:\\.txt");
                using (st)
                {
                    st.WriteLine("Fees Receipt");
                    st.WriteLine(label4.Text + ":" + txtonename.Text);
                    st.WriteLine(label5.Text + ":" + dateone.Text);
                    st.WriteLine(label8.Text + ":" + txtonephn.Text);
                    st.WriteLine(label6.Text + ":" + txtonedept.Text);
                    st.WriteLine(label7.Text + ":" + richTextBox4.Text);
                    st.WriteLine("Fees Paid");
                    MessageBox.Show("Fees paid");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fees_Load(object sender, EventArgs e)
        {

        }
    }
}
