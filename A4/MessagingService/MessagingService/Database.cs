using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagingService
{
    public class Database
    {
        public Dictionary<string, User> userIdToUser { get; }

        public Database()
        {
            userIdToUser = new Dictionary<string, User>();
        }
    }
}