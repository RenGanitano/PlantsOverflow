using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPlantsOverflow.Pages
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            FormatComment(txtuid.Text, txtcmnt.Text);
        }

        private void FormatComment(string username, string commenttext)
        {
            lblloadcomments.Text += "<table><tr><td><li>" + username + "</li><td>&nbsp;</td><td>&nbsp;</td></tr> <tr><td colspan='3'><h6>" + commenttext + "</h6></td></tr>"
           + "<tr><td><b<" + DateTime.Now.ToString() + "</b></td><td>&nbsp;</td><td>&nbsp;</td></tr></table><hr/>";
        }
    }
}