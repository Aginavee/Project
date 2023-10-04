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
    public partial class mark : Form
    {

        SqlDataAdapter adap = null;
        DataSet data = null;
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=true");
        public mark()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mark_Load(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("Select * from markk", conn);
            data = new DataSet();
            adap.Fill(data);
            datagridmarks.DataSource = data.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            student student = new student();
            student.ShowDialog();
            this.Close();
        }
    }
}
