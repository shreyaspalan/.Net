using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        calcService.WebService1 calc = new calcService.WebService1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.Add(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text)).ToString();
        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.sub(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text)).ToString();

        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.Mul(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text)).ToString();

        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.div(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text)).ToString();

        }
    }
}