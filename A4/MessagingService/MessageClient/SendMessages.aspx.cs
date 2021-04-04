using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MessageClient
{
    public partial class SendMessages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            alertUserMessage.Text = "";
            string receiverID = receiverIDTextBox.Text.Trim();
            string senderID = senderIDTextBox.Text.Trim();
            string message = messageTextBox.Text.Trim();

            if(receiverID.Length == 0 || senderID.Length == 0 || message.Length == 0)
            {
                alertUserMessage.Text = "Please enter a valid receiver ID, sender ID and a non blank message";
                return;
            }
            MsgService.MessagingServiceClient service = new MsgService.MessagingServiceClient();
            service.sendMessage(senderID, receiverID, message);

            alertUserMessage.Text = "Message sent!";
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}