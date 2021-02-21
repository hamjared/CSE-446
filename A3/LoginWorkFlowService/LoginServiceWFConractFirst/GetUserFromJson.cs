using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace LoginServiceWFConractFirst
{

    public sealed class GetUserFromJson : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> userName { get; set; }

        public OutArgument<User> user { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            if (File.Exists(HttpContext.Current.Server.MapPath("App_Data/users.json")))
            {
                string appData = File.ReadAllText(HttpContext.Current.Server.MapPath("App_Data/users.json"));
                Data data = JsonConvert.DeserializeObject<Data>(appData);
                if (data.getUser(context.GetValue(userName)) != null)
                {
                    context.SetValue(user, data.getUser(context.GetValue(userName)));
                    return;
                }
            }
            else
            {
                // the user cannot exist, since there are no users. 
                context.SetValue(user, null);
            }
        }
    }
}
