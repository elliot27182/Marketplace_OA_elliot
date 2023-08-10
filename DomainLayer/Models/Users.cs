using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Users
    {
        public int UsersID { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public string Password { get; set; }
    }
}
