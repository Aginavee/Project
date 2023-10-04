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
    public partial class atten : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=true");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds;
        public atten()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void studdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = studdatagrid.CurrentCell.RowIndex;
            DataGridViewRow row = studdatagrid.Rows[index];
            idtxt.Text = row.Cells[0].Value.ToString();
            nametxt.Text = row.Cells[1].Value.ToString();
            daystxt.Text = row.Cells[3].Value.ToString();
            depttxt.Text = row.Cells[2].Value.ToString();
            pretxt.Text = row.Cells[4].Value.ToString();
            abtxt.Text = row.Cells[5].Value.ToString(); 
            
        }

        private void atten_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from atten", con);
            ds = new DataSet();
            adapter.Fill(ds);
            studdatagrid.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into atten(Id,Name,dept,Totaldays,Dayspresent,Daysabsent) values(@id,@name,@Dept,@totaldays,@dayspresent,@daysabsent)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", idtxt.Text);
            cmd.Parameters.AddWithValue("@name", nametxt.Text);
            cmd.Parameters.AddWithValue("@Dept", depttxt.Text);
            cmd.Parameters.AddWithValue("@totaldays", daystxt.Text);
            cmd.Parameters.AddWithValue("@dayspresent", pretxt.Text);
            cmd.Parameters.AddWithValue("@daysabsent", abtxt.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            DisplayData();
            //ClearData();

        }
        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from atten", con);
            adapter.Fill(dt);
            studdatagrid.DataSource = dt;
            con.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete atten where Name=@name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", nametxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
            DisplayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.ShowDialog();
            this.Close();
        }
    }
}
