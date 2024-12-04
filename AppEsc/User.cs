using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEsc
{
    internal class User
    {
        public String userName;
        public String password;
        static public List<User> users = new List<User>();

        public User(String username, String password)
        {
            this.userName = username;
            this.password = password;
        }
    }
}
