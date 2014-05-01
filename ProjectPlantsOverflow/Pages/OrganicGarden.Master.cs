using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace ProjectPlantsOverflow.Pages
{
    public partial class OrganicGarden : System.Web.UI.MasterPage
    {
        plantsoverflowEntities rec = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            rec = new plantsoverflowEntities();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Close();
            con.Open();
            

            if(home.token == "home" || contact.token == "contact")
            {
                RadMenu1.Enabled = false;//make sure does not persist on other page loads
                RadMenu1.Visible = false;
                home.token = "";
                contact.token = "";
                
            }            
            if (recipe.token == "recipe")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM menurecipe", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet links = new DataSet();

                adapter.Fill(links);
                RadMenu1.DataTextField = "ptext";

                RadMenu1.DataFieldID = "id";
                //RadMenu1.DataFieldParentID = "id";

                RadMenu1.DataSource = links;
                RadMenu1.DataBind();
                recipe.token = "";
            }
            if (gardenguide.token == "gardenguide")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM menuyear", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet links = new DataSet();

                adapter.Fill(links);
                RadMenu1.DataTextField = "ptext";

                RadMenu1.DataFieldID = "id";
                //RadMenu1.DataFieldParentID = "id";

                RadMenu1.DataSource = links;
                RadMenu1.DataBind();
                gardenguide.token = "";
            }
            if (kids.token == "kids")
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM menukids", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet links = new DataSet();

                adapter.Fill(links);
                RadMenu1.DataTextField = "ptext";

                RadMenu1.DataFieldID = "id";
                //RadMenu1.DataFieldParentID = "id";

                RadMenu1.DataSource = links;
                RadMenu1.DataBind();
                kids.token = "";
            }
            con.Close();           
 
            //comments to be loaded
        }

        protected void RadMenu1_ItemClick(object sender, Telerik.Web.UI.RadMenuEventArgs e)
        {                
        /*FORMAT CONTENT NICELY???*/

            //annual content            
            string submenu = e.Item.Text;
            string html = "";

            if (submenu == "January")
            {
                html = "<p>December 29 – January 4  (20 weeks before last frost) - Sow Rosemary seeds indoors, 22 weeks before transplant time, in a medium pot." +
                        "January 19 – 25  (17 weeks before last frost)- rest</p>";
            }
            else if (submenu == "February")
            {
                html = "<p>February 9 – 15  (14 weeks before last frost)- Sow (15) sweet and (15) hot peppers indoors, 10 weeks before last frost, use a heat mat for 27C-30C.  After germination, use 16 hour grow light cycle.  After first true leaves appear, transplant into pots and lower soil temp to 21C (day) and 16C (night) for four weeks.  After 3rd set of true leaves appear, increase temp to 21C day and night.February 16 – 22  (13 weeks before last frost)- rest February 23 – March 1  (12 weeks before last frost)- Sow (8 black cherry, 8 tiny tim, 8 earliana) Tomatoes indoors, 12 weeks before last frost.- Stratify trumpet vine seeds for about 2-4 weeks before sowing.</p>";
            }
            else if (submenu == "March")
            {
                html = "<p>March 2 – 8  (11 weeks before last frost)- rest" +
                "March 9 – 15  (10 weeks before last frost) - Sow (6) Ground Cherry seeds indoors, 6-8 weeks before last frost, in .  Use a heat mat to increase temperature during germination." +
                "March 16 – 22  (9 weeks before last frost) - Sow Stevia seeds indoors, under lights, 7-8 weeks before transplant, in a medium pot.  Maintain 21-23C temperatures.  Only black or dark brown seeds are viable. - Sow Alyssum seeds indoors, 8-9 weeks before transplant. - Sow Impatien seeds indoors, 8-9 weeks before transplant." +
                "March 23 – 29  (8 weeks before last frost) - Sow Peppermint seeds indoors, 6-8 weeks before last frost, in a medium container. - Sow Chocolate Mint seeds indoors, 6-8 weeks before last frost, in a medium container. - Sow Orange Mint seeds indoors, 6-8 weeks before last frost, in a medium container.</p>";
            }
            else if (submenu == "April")
            {
                html = "<p>March 30 – April 5  (7 weeks before last frost) - Sow Parsley indoors, late winter to early spring, in a hanging basket. - Sow (12) Kale indoors, 5-7 weeks before last frost. - Sow Tarragon indoors, in a medium container, 6 weeks before last frost. - Sow Chamomile indoors, 6-8 weeks before last frost." +
                "April 6 – 12  (6 weeks before last frost) - Sow (18) Nasturtiums indoors, 4-6 weeks before last frost. - Sow Basil indoors, 4-6 weeks before last frost, in a hanging basket. - Sow Thai Basil indoors, 4-6 weeks before last frost, in a hanging basket. - Sow Chives indoors, 4 weeks before last frost, in a hanging basket.. - Sow (24) Echinacea indoors, 2-4 weeks before transplanting; place seeds in moist paper towel, and refrigerate for 1-2 weeks. - Sow Thyme indoors, 6 weeks before last frost, in a medium container." +
                "April 13 – 19  (5 weeks before last frost) - add compost & peat to gardens & containers - dig & cultivate - Scarify (10) Luffa seeds and soak for 24 hours before planting.  Plant indoors 4-5 weeks before last frost, use a heat mat to increase soil temperature. - Sow (8) chickpeas indoors, 3-4 weeks before last frost." + 
                "April 20 – 26  (4 weeks before last frost) - start hardening off plants - sift winter compost into temp bin - Sow (12) Cucumbers indoors, 3 weeks before last frost, 27C – 35C soil. - Sow Marjoram indoors, 4 weeks before setting out, in a medium pot.</p>";
            }
            else if (submenu == "May")
            {/*
                html = "<p>April 27 – May 3  (3 weeks before last frost) - Sow (12) Sunflowers indoors, 1-2 weeks before last frost; soak seeds between paper towel for 1-3 days first. - Sow (12 Golden, 12 Red) Beets outdoors, 3 weeks before last frost, in earthbox." +
                "May 4 – 10  (2 weeks before last frost) - Sow (60) Parsnip seeds outdoors early, as soon as the soil is workable, in an earthbox. Soak seeds beforehand.  Thin to 1”. - dig front garden" +
                "May 11 – 17  (1 week before last frost) - Sow (18) Pole Beans outdoors, 1 week before last frost. - buy soil for front garden - buy compost for all gardens - fill gardens with soil" +
                "May 18 – 24  (LAST FROST)
- put containers outdoors permanently
- Sow (30) Radishes outdoors, after last frost, in a window box. Repeat after harvesting.
- Sow Arugula & Chicory outdoors, after last frost.  They share a window box.  Repeat every 3 weeks during cool weather.
- Sow Spinach outdoors, after last frost.Repeat every 3 weeks during cool weather.
- Sow Rainbow Chard outdoors, after last frost.
- Sow Leaf Lettuce outdoors, after last frost.  Repeat every 3 weeks during cool weather.
- Transplant sunflowers after last frost.
- Transplant sweet and hot peppers after last frost.  Remove blossoms before and 2 weeks after transplanting.
- Transplant nasturtiums after last frost, into back and GG gardens.  Do not add fertilizer.
- Transplant luffa outdoors after last frost.
- Transplant tomatoes after last frost.
- Transplant cucumbers after last frost.
- Transplant echinacea after last frost.
- Transplant ground cherries (3) into earthbox after last frost.
- Transplant kale after last frost, in an earthbox.
- Transplant chickpeas into earthbox after last frost .

May 25 – 31  (1 week after last frost)
- Sow (40) Carrots outdoors, 1-2 weeks after last frost.
- Transplant heuchera plants one week after last frost, in well drained soil, in front garden.
</p>";*/
            }
            else if (submenu == "June")
            {
                html = "<p>June 1 – 7  (2 weeks after last frost)" +
                "<li>- Sow (12) Climbing Squash outdoors, 2 to 4 weeks after average last frost . Thin to 2 plants per mound.</li></p>";                    
            }
            else if (submenu == "July")
            {
                html = "";
            }
            else if (submenu == "August")
            {
                html = "";
            }
            else if (submenu == "September")
            {
                html = "";
            }
            else if (submenu == "October")
            {
                html = "";
            }
            else if (submenu == "November")
            {
                html = "<p>";
            }
            else if (submenu == "December")
            {
                html = "";
            }
            content.InnerHtml = html;                        
            
        }

        //private void LoadMenu()
        //{
        //    string pageName = this.Page.ToString().Substring(4, this.Page.ToString().Substring(4).Length - 5) + ".aspx";
        //    string[] page = pageName.Split('_');
        //    int id = 1;
        //    switch (page[1])
        //    {
        //        case "home.aspx":
        //            id = 1;
        //            break;
        //        case "":
        //            break;
        //        case "":
        //            break;
        //        case "":
        //            break;
        //        case "":
        //            break;
        //    };
        //}


        private void getMenu(int id)
        {
            RadMenu1.Items.Clear();
            rec = new plantsoverflowEntities();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string sql = "Select * from MainMenu";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            dt = ds.Tables[0];
            DataRow[] drowpar = dt.Select("ParentID=" + 0 + " and MenuID=" + 4);

            foreach (DataRow dr in drowpar)
            {
                RadMenuItem eg = new RadMenuItem();
                eg.Text = dr["MenuText"].ToString();
                eg.Value = dr["MenuID"].ToString();
                RadMenu1.Items.Add(eg);
            }

            DataRow[] sm = dt.Select("ParentID >" + 0);
            foreach (DataRow dr in sm)
            {
                RadMenuItem mnu = new RadMenuItem(dr["MenuText"].ToString(), "#");
                RadMenuItem rmi = RadMenu1.FindItemByValue(dr["ParentID"].ToString());
                if (rmi != null)
                {
                    RadMenu1.FindItemByValue(dr["ParentID"].ToString()).Items.Add(mnu);
                }
            }
            con.Close();

            RadMenu1.DataBind();
        }

        protected void btnpost_Click(object sender, EventArgs e)
        {
            FormatComment(txtuid.Text, txtcmnt.Text);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            string stmt = "INSERT INTO dbo.comments(username, comments) values(@username, @comments);";
            con.Open();
            SqlCommand cmd = new SqlCommand(stmt, con);
            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters.Add("@comments", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = txtuid.Text;
            cmd.Parameters["@comments"].Value = txtcmnt.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void FormatComment(string username, string commenttext)
        {
            lblloadcomments.Text += "<table><tr><td><li>" + username + "</li><td>&nbsp;</td><td>&nbsp;</td></tr> <tr><td colspan='3'><h6>" + commenttext + "</h6></td></tr>"
           + "<tr><td><b<" + DateTime.Now.ToString() + "</b></td><td>&nbsp;</td><td>&nbsp;</td></tr></table><hr/>";
        }
            //DataTable dt = new DataTable();
            //adt.Fill(dt);
            //GridView1.DataSource = dt;
           // GridView1.DataBind();
            //con.Close();
            //IQueryable<plantsoverflowEntities> recodsList = rec.Set<plantsoverflowEntities>();

            //foreach (plantsoverflowEntities op in recodsList)
            //{
               
            //}
           // RadMenu1.DataSource = rec.recipes;
           // RadMenu1.DataBind();

        }        
    }
