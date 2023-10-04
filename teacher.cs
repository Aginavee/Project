using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project.cs
{
    public partial class teacher : Form
    {
        SqlDataAdapter adap=null;
        DataSet data=null;
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=true");
        public teacher()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void teacher_Load(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("Select * from teac", conn);
            data = new DataSet();
            adap.Fill(data);
            teacherdatagrid.DataSource = data.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id=txtid.Text;
            int idd=Convert.ToInt32(id);
            string name=txtname.Text;
            string major=txtmajor.Text;
            string gender=comgen.Text;
            string phone=txtphone.Text;
            string dept=comdept.Text;
            string address=txtadd.Text;

            Applicat app= new Applicat();
            int result=app.LoadTeacher(idd,name, major, gender, phone, dept, address);
            if(result==1)
            {
                MessageBox.Show("Data saved");
            }
            else
            {
                MessageBox.Show("Data not saved");
            }
            ClearData();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home h=new home();
            h.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=teacherdatagrid.CurrentCell.RowIndex;
            DataGridViewRow row = teacherdatagrid.Rows[index];
            txtid.Text = row.Cells[0].Value.ToString();
            txtname.Text = row.Cells[1].Value.ToString();
            txtmajor.Text = row.Cells[2].Value.ToString();
            comgen.Text = row.Cells[3].Value.ToString();
            txtphone.Text = row.Cells[4].Value.ToString();
            comdept.Text = row.Cells[5].Value.ToString();
            txtadd.Text = row.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id= txtid.Text;
            int ids=Convert.ToInt32(id);
            string name=txtname.Text;
            string major = txtmajor.Text;
            string gender= comgen.Text;
            string phone= txtphone.Text;
            string dept=comdept.Text;
            string address=txtadd.Text;

            Applicat app = new Applicat();
            int resul=app.UpdateTeacher(ids,name, major, gender, phone,dept, address);
            if(resul==1)
            {
                MessageBox.Show("Changes updated");
            }
            else
            {
                MessageBox.Show("Changes not updated");
            }
            ClearData();

        }
        private void ClearData()
        {
            txtid.Text = "";
            txtname.Text = "";
            txtmajor.Text = "";
            comgen.Text = "";
            txtphone.Text = "";
            comdept.Text = "";
            txtadd.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            int ids = Convert.ToInt32(id);
            string name = txtname.Text;
            string major = txtmajor.Text;
            string gender = comgen.Text;
            string phone = txtphone.Text;
            string dept = comdept.Text;
            string address = txtadd.Text;

            Applicat app=new Applicat();
            int res = app.DeleteTeacher(ids, name, major, gender, phone, dept, address);
            if(res==1)
            {
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
            ClearData();
        }
    }
}
