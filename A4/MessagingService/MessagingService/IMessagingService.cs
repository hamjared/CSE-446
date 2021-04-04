using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MessagingService
{
    [ServiceContract]
    public interface IMessagingService

    {

        [OperationContract]
        void sendMessage(string senderID, string receiverID, string message);

        [OperationContract]
        string[] receiveMessage(string receiverID, bool purge);

    }

}
