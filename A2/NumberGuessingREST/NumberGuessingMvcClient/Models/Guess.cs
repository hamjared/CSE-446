using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.IO;

namespace NumberGuessingMvcClient.Models
{

    public class Guess
    {
        [Required]
        public int myGuess { get; set; }

        public string makeGuess(int secretNum)
        {
            string url = "http://localhost:63614/NumberGuessService.svc/checkGuess?userGuess=" + myGuess + "&secretNumber=" + secretNum;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream());

            string data = reader.ReadToEnd();
            return data;
        }
    }
}
