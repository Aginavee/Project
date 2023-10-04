using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace project.cs
{
    internal class Applicat
    {
        string Connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=true";
        string sqlquery = "select * from teac";
        SqlCommand comm = null;
        SqlConnection conn = null;
        SqlDataReader read = null;
        object[] obj;

        public Applicat()
        {
            conn = new SqlConnection(Connectionstring);
            conn.Open();
        }

        public int LoadTeacher(int tid, string name, string major, string gender, string phone, string dept, string address)

        {
            int x = 0;
            try
            {
                string sqlstatement = "insert into teac values(" + tid + ",'" + name + "','" + major + "','" + gender + "','" + phone + "','" + dept + "','" + address + "')";
                comm = new SqlCommand(sqlstatement, conn);
                x = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return x;

        }
        public int UpdateTeacher(int tid, string name, string major, string gender, string phone, string dept, string address)
        {
            int y = 0;
            try
            {
                string sqlstatement = "update teac set name='" + name + "',major = '"+major+"',gender='" + gender + "',phone='" + phone + "',department='" + dept + "',adddress='" + address + "' where tid=" + tid;
                comm = new SqlCommand(sqlstatement, conn);
                y= comm.ExecuteNonQuery();
                
            }
            catch (Exception ex) 
            {
                Console.WriteLine (ex.Message);
                MessageBox.Show(ex.Message);
            }
            return y;
        }
       
            public int DeleteTeacher(int tid, string name, string major, string gender, string phone, string dept, string address)
            {
            int z = 0;
            try
            {
                string sqlstatement = "delete teac where tid="+tid;
                comm = new SqlCommand(sqlstatement, conn);
                z = comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return z;
            }
        public object[] Feeload(int id)
        {
            comm = new SqlCommand("searchs", conn);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("FId", id);
            read=comm.ExecuteReader();
            int count = read.FieldCount;
            while(read.Read())
            {
                obj = new object[count];
                int res=read.GetValues(obj);
            }
            read.Close();
            return obj;
        }
       
    }
}
   



