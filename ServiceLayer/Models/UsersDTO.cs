using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class UsersDTO
    {
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public string Password { get; set; }
    }
}
