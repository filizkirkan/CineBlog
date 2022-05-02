using System;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.Sequence
{
    public partial class UserEntrance : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            User u = dm.UserEntrance(tb_mail.Text, tb_password.Text);
            if (u != null)
            {
                if (u.Statu == true)
                {
                    Session["user"] = u;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_message.Text = "Hesabınız Sistem Yöneticisi tarafından askıya alındı";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_message.Text = "Kullanıcı Bulunamadı. Email veya Şİfre Hatalı";

            }

        }


        protected void btn_signup_Click(object sender, EventArgs e)
        {
            User u = dm.UserEntrance(tb_mail.Text, tb_password.Text);
            if (u != null)
            {
                if (u.Statu == true)
                {
                    Session["user"] = u;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_message.Text = "Hesabınız Sistem Yöneticisi tarafından askıya alındı";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_message.Text = "Kullanıcı Bulunamadı. Email veya Şİfre Hatalı";

            }

        }






    }
}
