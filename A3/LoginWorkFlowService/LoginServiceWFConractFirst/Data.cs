using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginServiceWFConractFirst
{
    public class Data
    {
        public List<User> data { get; set; }

        public Data()
        {
            data = new List<User>();
        }

        public bool containsUserName(string userName)
        {
            for (int i = 0; i < data.Count; i++)
            {
                User user = data[i];
                if (user.userName.Equals(userName))
                {
                    return true;
                }
            }

            return false;
        }

        public void addUser(User user)
        {
            data.Add(user);
        }

        public User getUser(string userName)
        {
            for (int i = 0; i < data.Count; i++)
            {
                User user = data[i];
                if (user.userName.Equals(userName))
                {
                    return user;
                }
            }

            return null;
        }
    }
}