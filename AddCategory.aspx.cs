using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.Sequence.AdminPanel
{
    public partial class AddCategory : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_add_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Name = tb_name.Text;
            c.Statu = cb_statu.Checked;

            if (dm.AddCategory(c))
            {
                tb_name.Text = "";
                pnl_succesful.Visible = true;
                pnl_unsuccessful.Visible = false;
            }
            else
            {
                pnl_unsuccessful.Visible = true;
                pnl_succesful.Visible = false;
                lbl_message.Text = "Kategori eklenirken bir hata oluştu";
            }
        }
    }
}