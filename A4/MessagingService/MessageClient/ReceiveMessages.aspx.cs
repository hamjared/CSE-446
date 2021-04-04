using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MessageClient
{
    public partial class ReceiveMessages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            alertUserLabel.Text = "";
            purgeMessage.Text = "";
            messagesTextBox.Text = "";
            string receiveID = receiveIdTextBox.Text.Trim();
            if(receiveID.Length == 0)
            {
                alertUserLabel.Text = "Please enter a valid receiver ID";
                return;
            }


            MsgService.MessagingServiceClient service = new MsgService.MessagingServiceClient();
            string[] messages = service.receiveMessage(receiveID, purgeCheckBox.Checked);

            for( int i = 0; i < messages.Length; i++)
            {
                messagesTextBox.Text += messages[i] + "\n";
            }


            if (messages.Length == 0)
            {
                alertUserLabel.Text = "You have no unread messages";
            }

            if (purgeCheckBox.Checked)
            {
                purgeMessage.Text = "You messages have been purged.";
            }

        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}