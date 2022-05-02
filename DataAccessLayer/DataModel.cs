using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{


    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Admin Methods

        public Admin AdminEntrance(string Email, string Password)
        {
            Admin a = null;
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Admins WHERE Email=@m AND Password=@p";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@m", Email);
                cmd.Parameters.AddWithValue("@p", Password);
                con.Open();
                int number = Convert.ToInt32(cmd.ExecuteScalar());
                if (number == 1)
                {
                    a = new Admin();
                    cmd.CommandText = "SELECT A.ID, A.AdminTypeID, AT.Name, A.Name, A.Lastname, A.Email, A.Password, A.Statu FROM Admins AS A JOIN AdminTypes AS AT ON A.AdminTypeID = AT.ID WHERE A.Email=@m AND A.Password=@p";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@m", Email);
                    cmd.Parameters.AddWithValue("@p", Password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        a.ID = reader.GetInt32(0);
                        a.AdminTypeID = reader.GetInt32(1);
                        a.AdminType = reader.GetString(2);
                        a.Name = reader.GetString(3);
                        a.Lastname = reader.GetString(4);
                        a.Email = reader.GetString(5);
                        a.Password = reader.GetString(6);
                        a.Statu = reader.GetBoolean(7);
                    }
                }
                return a;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UserEntrance(User u)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Admin Methods - User

        public User UserEntrance(string email, string password)
        {
            User u = null;
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Email=@m AND Password=@p";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@m", email);
                cmd.Parameters.AddWithValue("@p", password);
                con.Open();
                int number = Convert.ToInt32(cmd.ExecuteScalar());
                if (number == 1)
                {
                    u = new User();
                    cmd.CommandText = "SELECT ID, Name, Lastname, Email, Password, Username, MembershipDate, Statu FROM Users WHERE Email=@m AND Password=@p";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@m", email);
                    cmd.Parameters.AddWithValue("@p", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        u.ID = reader.GetInt32(0);
                        u.Name = reader.GetString(1);
                        u.Lastname = reader.GetString(2);
                        u.Email = reader.GetString(3);
                        u.Password = reader.GetString(4);
                        u.Username = reader.GetString(5);
                        u.MembershipDate = reader.GetDateTime(6);
                        u.Statu = reader.GetBoolean(7);
                    }
                }
                return u;
            }
            finally
            {
                con.Close();
            }


        }

        public bool UserSignup(string email, string password)
        {
            User u = null;
            try
            {
                cmd.CommandText = "INSERT INTO Users(ID, Name, Lastname, Username, Email, Password, MembershipDate, Statu) VALUES(@id, @name, @lastname, @username, @email, @password, @membershipdate, @statu)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userid", u.ID);
                cmd.Parameters.AddWithValue("@name", u.Name);
                cmd.Parameters.AddWithValue("@lastname", u.Lastname);
                cmd.Parameters.AddWithValue("@username", u.Username);
                cmd.Parameters.AddWithValue("@email", u.Email);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@membershipdate", u.MembershipDate);
                cmd.Parameters.AddWithValue("@statu", u.Statu);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        //public List<User> UserList()
        //{
        //    try
        //    {
        //        List<User> User = new List<User>();
        //        cmd.CommandText = "SELECT ID, Username FROM User ";
        //        cmd.Parameters.Clear();
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while(reader.Read())
        //        {
        //            User u = new User();
        //            u.ID = reader.GetInt32(0);
        //            u.Username = reader.GetString(1);
        //            User.Add(u);
        //        }
        //        return User;

        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //}

        public List<Comment> CommentList()
        {
            List<Comment> comments = new List<Comment>();

            try
            {
                cmd.CommandText = "SELECT CM.ID, CM.UyeID, AR.Topic, CM.Date, CM.Statu FROM Comments";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Comment cm = new Comment();
                    cm.ID = reader.GetInt32(0);
                    cm.UserID = reader.GetInt32(1);
                    cm.UserName = reader.GetString(2);
                    cm.ArticleID = reader.GetInt32(3);
                    cm.Content = reader.GetString(4);
                    cm.Installeddate = reader.GetDateTime(5);
                    cm.Statu = reader.GetBoolean(6);
                    comments.Add(cm);
                }
                return comments;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        
        }

        public List<Comment> CommentList(int Did)
        {
            List<Comment> comments = new List<Comment>();

            try
            {
                cmd.CommandText = "SELECT CM.ID, CM.UserID, U.Name, AR.Topic, CM.Content, CM.Installeddate, CM.Statu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", Did);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Comment cm = new Comment();
                    cm.ID = reader.GetInt32(0);
                    cm.UserID = reader.GetInt32(1);
                    cm.UserName = reader.GetString(2);
                    cm.ArticleID = reader.GetInt32(3);
                    cm.Content = reader.GetString(4);
                    cm.Installeddate = reader.GetDateTime(5);
                    cm.Statu = reader.GetBoolean(6);
                    comments.Add(cm);
                }
                return comments;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Comment> CommentList(bool confirm)
            { 
            List<Comment> comments = new List<Comment>();
            try
            {
                cmd.CommandText = "SELECT CM.ID, CM.UserID, U.Name, CM.ArticeID, CM.Content, CM.Installeddate, CM.Statu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@d", confirm);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Comment cm = new Comment();
                    cm.ID = reader.GetInt32(0);
                    cm.UserID = reader.GetInt32(1);
                    cm.UserName = reader.GetString(2);
                    cm.ArticleID = reader.GetInt32(3);
                    cm.Content = reader.GetString(4);
                    cm.Installeddate = reader.GetDateTime(5);
                    cm.Statu = reader.GetBoolean(6);
                    comments.Add(cm);
                }
                return comments;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
            }
        
        public bool AddComment(Comment cm)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Comments(UserID, ArticleID, Content, Installeddate, Statu) VALUES(";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@userID", cm.UserID);
                cmd.Parameters.AddWithValue("@articleID", cm.ArticleID);
                cmd.Parameters.AddWithValue("@content", cm.Content);
                cmd.Parameters.AddWithValue("@intstalleddate", cm.Installeddate);
                cmd.Parameters.AddWithValue("@Statu", cm.Statu);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;




            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        


        
        #endregion

        #region Category Methods

        public bool AddCategory(Category cat)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(Name, Statu) VALUES(@name, @statu)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", cat.Name);
                cmd.Parameters.AddWithValue("@statu", cat.Statu);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool SelectCategory(Category cat)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM Categories";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", cat.Name);

                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }



        public List<Category> CategoryList()
        {
            try
            {
                List<Category> categories = new List<Category>();
                cmd.CommandText = "SELECT ID, Name, Statu FROM Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.ID = reader.GetInt32(0);
                    category.Name = reader.GetString(1);
                    category.Statu = reader.GetBoolean(2);
                    categories.Add(category);
                }
                return categories;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Category> CategoryList(bool statu)
        {
            try
            {
                List<Category> categories = new List<Category>();
                if (statu)
                {
                    cmd.CommandText = "SELECT ID, Name, Statu FROM Categories WHERE Statu = 1";
                }
                else
                {
                    cmd.CommandText = "SELECT ID, Name, Statu FROM Categories WHERE Statu = 0";
                }
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category category = new Category();
                    category.ID = reader.GetInt32(0);
                    category.Name = reader.GetString(1);
                    category.Statu = reader.GetBoolean(2);
                    categories.Add(category);
                }
                return categories;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteCategory(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM Categories WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally { con.Close(); }
        }

        public Category GetCategory(int id)
        {
            try
            {
                cmd.CommandText = "SELECT ID, Name, Statu FROM Categories WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Category c = new Category();
                while (reader.Read())
                {
                    c.ID = reader.GetInt32(0);
                    c.Name = reader.GetString(1);
                    c.Statu = reader.GetBoolean(2);
                }
                return c;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool EditCategory(Category cat)
        {
            try
            {
                cmd.CommandText = "UPDATE Categories SET Name=@name, Statu=@statu WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", cat.Name);
                cmd.Parameters.AddWithValue("@statu", cat.Statu);
                cmd.Parameters.AddWithValue("@id", cat.ID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public void ChangeCategoryStatu(int id)
        {
            try
            {
                cmd.CommandText = "SELECT Statu FROM Categories WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                bool statu = Convert.ToBoolean(cmd.ExecuteScalar());
                cmd.CommandText = "UPDATE Categories SET Statu = @statu WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@statu", !statu);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Article Methods

        public bool AddArticle(Article ar)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Articles(CategoryID, AuthorID, Topic, Summary, Content, Numberofviews, Coverphoto, Installeddate, Statu) VALUES(@categoryID, @authorID, @topic, @summary, @content, @numberofviews, @coverphoto, @installeddate, @statu)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@categoryID", ar.Category_ID);
                cmd.Parameters.AddWithValue("@authorID", ar.Author_ID);
                cmd.Parameters.AddWithValue("@topic", ar.Topic);
                cmd.Parameters.AddWithValue("@summary", ar.Summary);
                cmd.Parameters.AddWithValue("@content", ar.Content);
                cmd.Parameters.AddWithValue("@numberofviews", ar.Numberofviews);
                cmd.Parameters.AddWithValue("@coverphoto", ar.Coverphoto);
                cmd.Parameters.AddWithValue("@installeddate", ar.Installeddate);
                cmd.Parameters.AddWithValue("@statu", ar.Statu);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Article> ArticleList()
        {
            List<Article> Articles = new List<Article>();
            try
            {
                cmd.CommandText = "SELECT AR.ID, AR.CategoryID, AR.Name, AR.AuthorID, A.Name + ' ' + A.Lastname, AR.Topic, AR.Summary, AR.Content, AR.Numberofviews, AR.Coverphoto, AR.Installeddate, AR.Statu FROM Articles AS AR JOIN Categories AS C ON AR.CategoryID= C.ID JOIN Admins AS A ON AR.AuthorID=A.ID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Article ar = new Article();
                    ar.ID = reader.GetInt32(0);
                    ar.Category_ID = reader.GetInt32(1);
                    ar.Category = reader.GetString(2);
                    ar.Author_ID = reader.GetInt32(3);
                    ar.Author = reader.GetString(4);
                    ar.Topic = reader.GetString(5);
                    ar.Summary = reader.GetString(6);
                    ar.Content = reader.GetString(7);
                    ar.Numberofviews = reader.GetInt32(8);
                    ar.Coverphoto = reader.GetString(9);
                    ar.Installeddate = reader.GetDateTime(10);
                    ar.Statu = reader.GetBoolean(11);
                    Articles.Add(ar);
                }
                return Articles;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Article> ArticleList(int catid)
        {
            List<Article> Articles = new List<Article>();
            try
            {
                cmd.CommandText = "SELECT AR.ID, AR.CategoryID, C.Name, AR.AuthorID, A.Name + ' ' + A.Lastname, AR.Topic, AR.Summary, AR.Content, AR.Numberofviews, AR.Coverphoto, AR.Installeddate, AR.Statu FROM Articles AS AR JOIN Categories AS C ON AR.CategoryID= C.ID JOIN Admins AS A ON AR.AuthorID=A.ID WHERE AR.CategoryID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", catid);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Article ar = new Article();
                    ar.ID = reader.GetInt32(0);
                    ar.Category_ID = reader.GetInt32(1);
                    ar.Category = reader.GetString(2);
                    ar.Author_ID = reader.GetInt32(3);
                    ar.Author = reader.GetString(4);
                    ar.Topic = reader.GetString(5);
                    ar.Summary = reader.GetString(6);
                    ar.Content = reader.GetString(7);
                    ar.Numberofviews = reader.GetInt32(8);
                    ar.Coverphoto = reader.GetString(9);
                    ar.Installeddate = reader.GetDateTime(10);
                    ar.Statu = reader.GetBoolean(11);
                    Articles.Add(ar);
                }
                return Articles;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public Article GetArticle(int id)
        {
            try
            {
                cmd.CommandText = "SELECT AR.ID, AR.CategoryID, C.Name, AR.AuthorID, A.Name + ' ' + A.Lastname, AR.Topic, AR.Summary, AR.Content, AR.Numberofviews, AR.Coverphoto, AR.Installeddate, AR.Statu FROM Articles AS AR JOIN Categories AS C ON AR.CategoryID= C.ID JOIN Admins AS A ON AR.AuthorID=A.ID WHERE AR.ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Article ar = new Article();
                while (reader.Read())
                {

                    ar.ID = reader.GetInt32(0);
                    ar.Category_ID = reader.GetInt32(1);
                    ar.Category = reader.GetString(2);
                    ar.Author_ID = reader.GetInt32(3);
                    ar.Author = reader.GetString(4);
                    ar.Topic = reader.GetString(5);
                    ar.Summary = reader.GetString(6);
                    ar.Content = reader.GetString(7);
                    ar.Numberofviews = reader.GetInt32(8);
                    ar.Coverphoto = reader.GetString(9);
                    ar.Installeddate = reader.GetDateTime(10);
                    ar.Statu = reader.GetBoolean(11);
                }

                return ar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void IncreaseArticleViews(int id)
        {
            try
            {
                cmd.CommandText = "SELECT Numberofviews FROM Articles WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                int number = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.CommandText = "UPDATE Articles SET Numberofviews = @nv WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nv", number + 1);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        

       


    }


}



