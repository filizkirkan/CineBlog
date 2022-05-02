using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace _2.Sequence.AdminPanel
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                DataAccessLayer.Admin a = (DataAccessLayer.Admin)Session["admin"];
                lbl_user.Text = a.Name + " " + a.Lastname + " (" + a.AdminType + ")";
            }
            else
            {
                Response.Redirect("AdminEntrance.aspx");
            }
        }

        protected void lbtn_logout_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("AdminEntrance.aspx");
        }
    }
}