using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NumberGuessing
{
    [ServiceContract]
    public interface INumberGuessing
    {

        [OperationContract]
        string checkNumber(int userNum, int SecretNum);

        [OperationContract]
        int SecretNumber(int lower, int upper);

    }
}
