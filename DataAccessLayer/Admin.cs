using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Admin
    {
        public int ID { get; set; }
        public int AdminTypeID { get; set; }
        public string AdminType { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Statu { get; set; }
    }
}
