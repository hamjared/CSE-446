using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagingService
{
    public class User
    {
        public List<Message> messages;

        public User()
        {
            messages = new List<Message>();
        }

        public void addMessage(Message message)
        {
            messages.Add(message);
        }

        public void removeAllMessages()
        {
            messages.Clear();

        }

        public List<Message> getUnreadMessages()
        {
            List<Message> unreadMessages = new List<Message>();
            foreach (Message msg in messages)
            {
                if (!msg.hasBeenRead)
                {
                    unreadMessages.Add(msg);
                    msg.hasBeenRead = true;
                }
            }
            return unreadMessages;
        }
    }
}