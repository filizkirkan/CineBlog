﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace _2.Sequence.AdminPanel
{
    public partial class Default : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            //lv_articles.DataSource = dm.ArticleList();
            //lv_articles.DataBind();
        }
    }
}