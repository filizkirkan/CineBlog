using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Comment
    {
        public int ID { get; set; }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public int ArticleID { get; set; }
        public string Content { get; set; }
        public DateTime Installeddate { get; set; }
        public bool Statu { get; set; }
    }
}
