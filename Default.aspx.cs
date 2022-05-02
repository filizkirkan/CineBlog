using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace _2.Sequence
{
    public partial class Default : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count == 0)
            {
                lv_articles.DataSource = dm.ArticleList();
            }
            else
            {
                int catid = Convert.ToInt32(Request.QueryString["cid"]);
                lv_articles.DataSource = dm.ArticleList(catid);
            }
            
            lv_articles.DataBind();
        }
    }
}