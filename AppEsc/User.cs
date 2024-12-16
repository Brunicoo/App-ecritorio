using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEsc
{
    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        static public List<User> users = new List<User>();

        public User(String username, String password)
        {
            this.userName = username;
            this.password = password;
        }
    }
}
