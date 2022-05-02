using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace _2.Sequence.AdminPanel
{
    public partial class EditCategory : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["kid"]);
                    Category c = dm.GetCategory(id);
                    tb_name.Text = c.Name;
                    cb_statu.Checked = c.Statu;
                }
            }
            else
            {
                Response.Redirect("CategoryListList.aspx");
            }
        }

        protected void lbtn_edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["kid"]);
            Category c = new Category();
            c.ID = id;
            c.Name = tb_name.Text;
            c.Statu = cb_statu.Checked;

            if (dm.EditCategory(c))
            {
                pnl_successful.Visible = true;
                pnl_unsuccessful.Visible = false;
            }
            else
            {
                pnl_successful.Visible = false;
                pnl_unsuccessful.Visible = true;
                lbl_message.Text = "Kategori güncellenirken bir hata oluştu";
            }
        }
    }
}