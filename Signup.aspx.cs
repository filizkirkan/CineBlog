using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;


namespace _2.Sequence
{
    public partial class Signup : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btn_enter_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = tb_name.Text;
            u.Lastname = tb_lastname.Text;
            u.Username = tb_username.Text;
            u.Email = tb_email.Text;
            u.Password = tb_password.Text;
            u.MembershipDate = DateTime.Now;
            u.Statu = true;

            if (dm.UserEntrance(u))
            {
                return;
            }
            if (tb_password.Text == tb_confirmpassword.Text)
            {
                Response.Redirect("Default.aspx");
                pnl_successful.Visible = true;
                lbl_successful.Text = "Kayit olustu";
            }
            else
            {
                pnl_unsuccessful.Visible = true;
                lbl_unsuccessful.Text = "sifreler farkli";
            }



        }
    }
}