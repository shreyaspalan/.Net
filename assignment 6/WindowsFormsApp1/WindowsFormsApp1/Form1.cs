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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
                    SqlCommand cmd;
                    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shreyas\source\repos\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True");
            cmd = new SqlCommand("insert into Students (Name,Enrollment,Email)values ( '"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')", con);
            con.Open();
            int x = cmd.ExecuteNonQuery();
            if(x ==1){
                Console.WriteLine("sucess");
                         
            }
        }
    }
}
