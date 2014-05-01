using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPlantsOverflow.Pages
{
    public partial class home : System.Web.UI.Page
    {
        public static string token;

        protected void Page_Load(object sender, EventArgs e)
        {
            token = "home";
        }
    }
}