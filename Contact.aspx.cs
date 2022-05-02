using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace _2.Sequence
{
    public partial class Contact : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            //        protected void Button1_Click(object sender, EventArgs e)
            //        {
            //            try
            //            {
            //                if (Page.IsValid)
            //                {
            //                    MailMessage mailMessage = new MailMessage();
            //                    mailMessage.From = new MailAddress("filizkirkan@gmail.com");
            //                    mailMessage.To.Add("AdministratorID@bilisim.com");
            //                    mailMessage.Subject = txtSubject.Text;

            //                    mailMessage.Body = "<b>Sender Name : </b>" + txtName.Text + "<br/>"
            //                        + "<b>Sender Email : </b>" + txtEmail.Text + "<br/>"
            //                        + "<b>Comments : </b>" + txtComments.Text;
            //                    mailMessage.IsBodyHtml = true;


            //                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            //                    smtpClient.EnableSsl = true;
            //                    smtpClient.Credentials = new
            //                        System.Net.NetworkCredential("filizkirkan@gmail.com", "12345");
            //                    smtpClient.Send(mailMessage);

            //                    Label1.ForeColor = System.Drawing.Color.Blue;
            //                    Label1.Text = "Thank you for contacting us";

            //                    txtName.Enabled = false;
            //                    txtEmail.Enabled = false;
            //                    txtComments.Enabled = false;
            //                    txtSubject.Enabled = false;
            //                    Button1.Enabled = false;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                
            //                Label1.ForeColor = System.Drawing.Color.Red;
            //                Label1.Text = "There is an unkwon problem. Please try later";
            //            }
            //        }

            //    }
            //}
        }
    }
}