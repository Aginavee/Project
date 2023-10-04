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
    public partial class student : Form
    {
        SqlConnection con =new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=true");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataSet ds;
        //int ID = 0;
        public student()
        {
            InitializeComponent();
            DisplayData();
        }

        private void student_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from stud", con);
            ds = new DataSet();
            adapter.Fill(ds);
            studdatagrid.DataSource = ds.Tables[0];
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into stud(Id,Name,Gender,Dob,Department,Phone,Address) values(@id,@name,@gender,@dob,@dept,@phone,@address)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", idtxt.Text);
            cmd.Parameters.AddWithValue("@name", nametxt.Text);
            cmd.Parameters.AddWithValue("@gender",gentxt.Text);
            cmd.Parameters.AddWithValue("@dob", date.Text);
            cmd.Parameters.AddWithValue("@dept", depttxt.Text);
            cmd.Parameters.AddWithValue("@phone", phntxt.Text);
            cmd.Parameters.AddWithValue("@address", addtxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            DisplayData();
            ClearData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=studdatagrid.CurrentCell.RowIndex;
            DataGridViewRow row = studdatagrid.Rows[index];
            idtxt.Text = row.Cells[0].Value.ToString();
            nametxt.Text = row.Cells[1].Value.ToString();
            phntxt.Text = row.Cells[4].Value.ToString();
            depttxt.Text = row.Cells[5].Value.ToString();
            addtxt.Text = row.Cells[6].Value.ToString();
            gentxt.Text = row.Cells[2].Value.ToString();
            date.Value = (DateTime)row.Cells[3].Value;

        }

        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from stud", con);
            adapter.Fill(dt);
            studdatagrid.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            idtxt.Text = "";
            nametxt.Text = "";
            phntxt.Text = "";
            depttxt.Text = "";
            addtxt.Text = "";
            gentxt.Text = "";
            date.Text = "";
            //ID = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update stud set Id=@id,Name=@name,Dob=@dob,Gender=@gender,Department=@dept,Phone=@phone,Address=@address where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", idtxt.Text);
            cmd.Parameters.AddWithValue("@name", nametxt.Text);
            cmd.Parameters.AddWithValue("@gender", gentxt.Text);
            cmd.Parameters.AddWithValue("@dob", date.Text);
            cmd.Parameters.AddWithValue("@dept", depttxt.Text);
            cmd.Parameters.AddWithValue("@phone", phntxt.Text);
            cmd.Parameters.AddWithValue("@address", addtxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();
            DisplayData();
            ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete stud where Name=@name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@name", nametxt.Text);
            //cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");
            DisplayData();
            ClearData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.ShowDialog();
            this.Close();
        }

        private void phntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mark m=new mark();
            m.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
