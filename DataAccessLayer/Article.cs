using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Article
    {
        public int ID { get; set; }
        public int Category_ID { get; set; }
        public string Category { get; set; }
        public int Author_ID { get; set; }
        public string Author { get; set; }
        public string Topic { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int Numberofviews { get; set; }
        public string Coverphoto { get; set; }
        public DateTime Installeddate { get; set; }
        public bool Statu { get; set; }
    }
}
