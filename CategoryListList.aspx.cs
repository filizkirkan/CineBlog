using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace _2.Sequence.AdminPanel
{
    public partial class CategoryListList : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_categories.DataSource = dm.CategoryList();
            lv_categories.DataBind();
        }

        protected void lv_categories_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "delete")
            {
                dm.DeleteCategory(id);
            }
            if (e.CommandName == "statu")
            {
                dm.ChangeCategoryStatu(id);
            }
            lv_categories.DataSource = dm.CategoryList();
            lv_categories.DataBind();
        }
    }
}
