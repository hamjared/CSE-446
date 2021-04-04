using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace MessagingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MessagingService : IMessagingService
    {
        public string[] receiveMessage(string receiverID, bool purge)
        {
            Database db = getDatabase();
            User user;
            if (db.userIdToUser.ContainsKey(receiverID))
            {
                user = db.userIdToUser[receiverID];
            }
            else
            {
                return null;
            }

            List<Message> msgs = user.getUnreadMessages();
            string[] msgsString = new string[msgs.Count];
            int i = 0;
            foreach (Message msg in msgs)
            {
                msgsString[i++] = msg.ToString();
            }

            if (purge)
            {
                user.removeAllMessages();
            }
            //update the local DB before returning. 
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText(HttpContext.Current.Server.MapPath("App_Data/database.json"), json);

            

            return msgsString;
        }

        public void sendMessage(string senderID, string receiverID, string message)
        {
            Database db = getDatabase();
            User user;
            if (db.userIdToUser.ContainsKey(receiverID)) {
                user = db.userIdToUser[receiverID];
            }
            else
            {
                user = new User();
                db.userIdToUser[receiverID] = user;
            }

            Message msg = new Message(senderID, receiverID, message, DateTime.Now.ToString());

            user.addMessage(msg);

            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText(HttpContext.Current.Server.MapPath("App_Data/database.json"), json);
        }


        private string getDataFromFile()
        {
            if (File.Exists(HttpContext.Current.Server.MapPath("App_Data/database.json")))
            {
                return File.ReadAllText(HttpContext.Current.Server.MapPath("App_Data/database.json"));
            }
            else
            {
                return null;
            }
        }

        private Database getDatabase()
        {
            string DBContents = getDataFromFile();
            if (DBContents == null)
            {
                return new Database();
            }
            return  JsonConvert.DeserializeObject<Database>(DBContents);
        }
    }
}
