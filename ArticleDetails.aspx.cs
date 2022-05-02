using System;
using DataAccessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.Sequence
{
    public partial class ArticleDetails : System.Web.UI.Page
    {
        DataModel dm = new DataModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                int id = Convert.ToInt32(Request.QueryString["mid"]);
                dm.IncreaseArticleViews(id);
                Article ar = dm.GetArticle(id);
                ltrl_topic.Text = ar.Topic;
                img_resim.ImageUrl = "Assets/MakaleResim/" + ar.Coverphoto;
                ltrl_numberofviews.Text = ar.Numberofviews.ToString();
                ltrl_content.Text = ar.Content;
                ltrl_category.Text = ar.Category;
                ltrl_author.Text = ar.Author;
                ltrl_summary.Text = ar.Summary;

                if(Session["user"] !=null)
                {
                    pnl_entrancesuccessful.Visible = true;
                    pnl_entranceunsuccessful.Visible = false;
                }
                else
                {
                    pnl_entrancesuccessful.Visible = false;
                    pnl_entranceunsuccessful.Visible = true;
                }
                //rp_comments.DataSource = dm.CommentList(id);
                //rp_comments.DataBind();

            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        
        protected void lbtn_addcomment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["did"]);
            Comment cm = new Comment();
            cm.ID = id;
            cm.UserID = ((User)Session["uye"]).ID;
            cm.Content = tb_comment.Text;
            cm.Installeddate = DateTime.Now;
            cm.Statu = false;
            
            if(dm.AddComment(cm))
            {
                if(dm.AddComment(cm))
                {
                    Response.Write("<script>alert('Comment received. It will post after cofirmation.')</script>");
                }
                else 
                {
                    Response.Write("<script>alert('Unsuccessful')</script>");
                }
            }

        }

      
    }


}
