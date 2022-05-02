using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.IO;
using System.Data;


namespace _2.Sequence.AdminPanel
{
    public partial class AddArticle : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_categories.DataSource = dm.CategoryList(true);
                ddl_categories.DataBind();
                
            }else
            {
                Response.Redirect("AddArticle.aspx");
            }
        }

        protected void lbtn_add_Click(object sender, EventArgs e)
        {
            Article ar = new Article();
            ar.Topic = tb_name.Text;
            ar.Content = tb_content.Text;
            ar.Summary = tb_summary.Text;
            ar.Category_ID = Convert.ToInt32(ddl_categories.SelectedItem.Value);
            ar.Author_ID = ((DataAccessLayer.Admin)Session["admin"]).ID;
            ar.Installeddate = DateTime.Now;
            ar.Statu = cb_statu.Checked;
            ar.Numberofviews = 0;
            if (fu_photo.HasFile)
            {
                FileInfo fi = new FileInfo(fu_photo.FileName);
                string extention = fi.Extension;//.png, // .jpg
                if (extention == ".png" || extention == ".jpg" || extention == ".jpeg")
                {
                    string name = Guid.NewGuid().ToString() + extention;
                    fu_photo.SaveAs(Server.MapPath("~/Assets/ArticlePhotos/" + name));
                    ar.Coverphoto = name;
                }
                else
                {
                    pnl_unsuccessful.Visible = true;
                    pnl_successful.Visible = false;
                    lbl_message.Text = "File format must be image.";
                }
            }
            else
            {
                ar.Coverphoto = "none.png";
            }

            if (dm.AddArticle(ar))
            {
                pnl_unsuccessful.Visible = false;
                pnl_successful.Visible = true;
            }
            else
            {
                pnl_unsuccessful.Visible = true;
                pnl_successful.Visible = false;
                lbl_message.Text = "An error occured while loading.";
            }
        }
    }
}