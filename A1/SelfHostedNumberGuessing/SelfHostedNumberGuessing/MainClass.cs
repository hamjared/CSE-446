using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHostedNumberGuessing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:4446/Service");
            ServiceHost selfHost = new ServiceHost(typeof(SelfHostedNumberGuessing), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(ISelfHostedNumberGuessing), new WSHttpBinding(), "SelfHostedNumberGuessingService");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost.Open();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Error starting service");
            }

            Console.WriteLine("Service is ready to take requests");
            Console.WriteLine("Press <ENTER> to stop the service. ");
            Console.ReadLine();
            selfHost.Close();
        }
    }
}
