using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net;
using System.IO;

namespace NumberGuessingMvcClient.Models
{
    public class GenerateSecretNumber
    {
        [Required(ErrorMessage ="Please enter a lower limit")]
        public int lowerLimit { get; set; }
        [Required(ErrorMessage = "Please enter a upper limit")]
        public int upperLimit { get; set; }

        public int generateSecretNumber()
        {
            string url = "http://localhost:63614/NumberGuessService.svc/generateSecretNumber?lowerLimit=" + lowerLimit + "&upperLimite=" + upperLimit;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream());

            string data = reader.ReadToEnd();



            return Int32.Parse(data);
        }
    }
}
