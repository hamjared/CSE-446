using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Activities;

namespace LoginServiceWFConractFirst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool CreateUser(string userName, string password)
        {
            Dictionary<string, object> arguments = new Dictionary<string, object>();
            arguments.Add("userName", userName);
            arguments.Add("password", password);
            IDictionary<string, object> outputs =  WorkflowInvoker.Invoke(new CreateUserActivity(), arguments);
            return (bool)outputs["wasUserCreated"];
        }

        public bool login(string userName, string password)
        {
            Dictionary<string, object> arguments = new Dictionary<string, object>();
            arguments.Add("userName", userName);
            arguments.Add("password", password);
            IDictionary<string, object> outputs = WorkflowInvoker.Invoke(new LoginActivity(), arguments);
            return (bool)outputs["wasSuccesfullLogin"];
        }
    }
}
