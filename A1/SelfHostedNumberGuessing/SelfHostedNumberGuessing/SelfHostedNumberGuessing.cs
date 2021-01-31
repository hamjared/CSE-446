using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHostedNumberGuessing
{
    [ServiceContract]
    public interface ISelfHostedNumberGuessing
    {

        [OperationContract]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        string checkNumber(int userNum, int SecretNum);
    }
    
    public class SelfHostedNumberGuessing : ISelfHostedNumberGuessing
    {
        public int SecretNumber(int lower, int upper)
        {
            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random(seed);
            int sNumber = random.Next(lower, upper);
            return sNumber;
        }
        public string checkNumber(int userNum, int SecretNum)
        {
            if (userNum == SecretNum)
                return "correct";
            else
            if (userNum > SecretNum)
                return "too big";
            else return "too small";
        }
    }
}
