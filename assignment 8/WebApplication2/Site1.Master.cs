using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Label Lblname
        {
            get
            {
                return lblname;
            }
        }

        public Button Btnsearch
        {
            get
            {
                return btnsearch;
            }
        }

        public TextBox Txtsearch
        {
            get
            {
                return txtsearch;
            }
        }

    }
}