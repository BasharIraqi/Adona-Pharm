using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adona_Pharm
{
    static class Users
    {
       public static List<User> users = new List<User>()
       {
            new User("Manager","mmm123456"),
            new User("Department Manager","d123456"),
            new User("Shift Manager","sm123"),
            new User("General","g123"),
       };

    }

    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
