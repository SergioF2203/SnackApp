using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackApp.UserServices
{
    public static class UserInitialaizer
    {
        public static List<User> GetSampleUserData()
        {
            var users = new List<User>();

            users.Add(new User { Name = "SomeName", Score = 123 });
            users.Add(new User { Name = "Some2Name", Score = 125 });
            users.Add(new User { Name = "Some3Name", Score = 3 });

            return users;
        }
    }
}
