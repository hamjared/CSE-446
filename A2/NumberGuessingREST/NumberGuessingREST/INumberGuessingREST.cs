using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NumberGuessingREST
{
    [ServiceContract]
    public interface INumberGuessingREST
    {

        [OperationContract]
        [WebGet(UriTemplate="generateSecretNumber?lowerLimit={lower}&upperLimite={upper}", 
            ResponseFormat = WebMessageFormat.Json)]
        int SecretNumber(int lower, int upper);

        [OperationContract]
        [WebGet(UriTemplate = "checkGuess?userGuess={userNum}&secretNumber={SecretNum}",
            ResponseFormat = WebMessageFormat.Json)]
        string checkNumber(int userNum, int SecretNum);

    }
}
