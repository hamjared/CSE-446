using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NumberGuessingMvcClient.Models;
using System.Net;
using System.IO;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace NumberGuessingMvcClient.Controllers
{
    public class HomeController : Controller
    
    {

        static Dictionary<Guid, int> guidToSecretNumber = new Dictionary<Guid, int>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        

        public ActionResult GenerateSecretNumber(GenerateSecretNumber gsn)
        {
            if (ModelState.IsValid)
            {

                Guid guid = Guid.NewGuid();

                string url = "http://localhost:63614/NumberGuessService.svc/generateSecretNumber?lowerLimit=" + gsn.lowerLimit + "&upperLimit=" + gsn.upperLimit;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";

                RequestState reqState = new RequestState();
                reqState.request = req;
                reqState.guid = guid;
                req.BeginGetResponse(new AsyncCallback(callback), reqState);
                

                HttpContext.Session.SetString("secretNumberGuid", guid.ToString());


                return View("GuessTheNumber");
            }
            else
            {
                return View("Index");
            }
        }

        private void callback(IAsyncResult requestObj)
        {
            RequestState state = (RequestState)requestObj.AsyncState;
            HttpWebRequest hwReq2 = (HttpWebRequest)state.request;
            HttpWebResponse resp = (HttpWebResponse)hwReq2.EndGetResponse(requestObj);
            StreamReader reader = new StreamReader(resp.GetResponseStream());

            string data = reader.ReadToEnd();

            int secretNumber = Int32.Parse(data);
            guidToSecretNumber.Add(state.guid, secretNumber);

        }

        public ActionResult GuessNumber(Guess guess)
        {
            if (ModelState.IsValid)
            {
                if (HttpContext.Session.GetInt32("attempts") == null)
                {
                    HttpContext.Session.SetInt32("attempts", 1);
                }
                else
                {
                    HttpContext.Session.SetInt32("attempts", (int)(HttpContext.Session.GetInt32("attempts") + 1));
                }

                Guid guid = new Guid(HttpContext.Session.GetString("secretNumberGuid"));
                int secretNumber;
                try
                {
                    secretNumber = guidToSecretNumber[guid];
                }
                catch (KeyNotFoundException){
                    ViewData["hint"] = "Please wait while your secret number is generated";
                    return View("GuessTheNumber");
                }
                    
                ViewData["hint"] = guess.makeGuess(secretNumber);
                return View("GuessTheNumber");
            }
            else
            {
                return View("GuessTheNumber");
            }
            
        }
    }

    public class RequestState
    {
        public HttpWebRequest request;
        public Guid guid;
    }
}
