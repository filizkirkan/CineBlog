using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace _2.Sequence.AdminPanel
{

    public partial class AdminEntrance : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enter_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tb_mail.Text))
            {
                if (!string.IsNullOrEmpty(tb_password.Text))
                {
                    DataAccessLayer.Admin a = dm.AdminEntrance(tb_mail.Text, tb_password.Text);

                    if (a != null)
                    {
                        if (a.Statu)
                        {
                            Session["admin"] = a;
                            Response.Redirect("Default.aspx");
                        }
                        else
                        {
                            lbl_message.Text = "Your account has been suspended by the system administrator.";
                            pnl_error.Visible = true;
                        }
                    }
                    else
                    {
                        lbl_message.Text = "User not found.";
                        pnl_error.Visible = true;
                    }

                }
                else
                {
                    lbl_message.Text = "Password cannot be left blank.";
                    pnl_error.Visible = true;
                }
            }
            else
            {
                lbl_message.Text = "Mail cannot be left blank.";
                pnl_error.Visible = true;
            }

        }
    }
}