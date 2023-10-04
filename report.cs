using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.cs
{
    public partial class report : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=true");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds;
        public report()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("select stud.name,stud.gender,stud.dob,stud.phone,stud.department,stud.address,atten.daysabsent,atten.dayspresent,markk.subject1,markk.subject2,markk.subject3,markk.subject4,markk.subject5,markk.average from stud inner join markk on stud.id=markk.id inner join atten on markk.id=atten.id", con);
            ds = new DataSet();
            adapter.Fill(ds);
            datagridreport.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.ShowDialog();
            this.Close();
        }
    }
}
