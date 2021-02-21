using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace LoginServiceWFConractFirst
{

    public sealed class AddUserToJson : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> userName { get; set; }

        public InArgument<string> password { get; set; }

        public OutArgument<bool> wasSuccessful { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            Data data;
            if (File.Exists(HttpContext.Current.Server.MapPath("App_Data/users.json"))){
                string appData = File.ReadAllText(HttpContext.Current.Server.MapPath("App_Data/users.json"));
                data = JsonConvert.DeserializeObject<Data>(appData);
                if (data.containsUserName(context.GetValue(userName)))
                {
                    context.SetValue(wasSuccessful, false);
                    return;
                }
               
            }
            else
            {
                data = new Data();
            }

            User user = new User(context.GetValue(userName), context.GetValue(password));
            data.addUser(user);

            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(HttpContext.Current.Server.MapPath("App_Data/users.json"), json);
            context.SetValue(wasSuccessful, true);
        }
    }
}
