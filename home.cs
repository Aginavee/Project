using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.cs
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student std = new student();
            std.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report dep = new report();
            dep.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teacher tea = new teacher();
            tea.ShowDialog();
            this.Close();
        }

        private void btnatten_Click(object sender, EventArgs e)
        {
            atten att= new atten();
            att.ShowDialog();
            this.Close();
        }

        private void btnfees_Click(object sender, EventArgs e)
        {
            fees fee= new fees();
            fee.ShowDialog();
            this.Close();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login log = new login();
            log.ShowDialog();
            this.Close();
        }
    }
}
