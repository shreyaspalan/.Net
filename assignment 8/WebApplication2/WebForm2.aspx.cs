using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ((Site1)Master).Btnsearch.Click += new EventHandler(Btnsearch_Click);
        }
        void Btnsearch_Click(object sender, EventArgs e)
        {
            getData();
        }
        void getData()
        {
            string s = ((Site1)Master).Txtsearch.Text; Console.WriteLine(s);
            string source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shreyas\source\repos\WebApplication2\WebApplication2\App_Data\Database1.mdf;Integrated Security=True";
            string select = "select * from Students where Fname like '%" + ((Site1)Master).Txtsearch.Text + "%'";
            SqlConnection con = new SqlConnection(source);
            SqlCommand cmd = new SqlCommand(select, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            grdstudent.DataSource = rdr; grdstudent.DataBind();
            con.Close();
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}