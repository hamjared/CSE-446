using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagingService
{
    public class Message
    {

        public string timeCreated { get; }
        public string senderID { get; }
        public string receiverID { get; }
        public string message { get; }
        public bool hasBeenRead { get; set; }

        public Message(string senderID, string receiverID, string message, string timeCreated, bool hasBeenRead = false)
        {
            this.timeCreated = timeCreated;
            this.senderID = senderID;
            this.receiverID = receiverID;
            this.message = message;
            this.hasBeenRead = hasBeenRead;
        }


        public override string ToString()
        {
            return timeCreated.ToString() + ": From " + senderID + ": " + message;
        }
    }
}