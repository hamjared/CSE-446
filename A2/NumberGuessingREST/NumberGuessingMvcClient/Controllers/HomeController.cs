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
                //int secretNumber = gsn.generateSecretNumber();
                string url = "http://localhost:63614/NumberGuessService.svc/generateSecretNumber?lowerLimit=" + gsn.lowerLimit + "&upperLimite=" + gsn.upperLimit;
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(resp.GetResponseStream());

                string data = reader.ReadToEnd();

                int secretNumber = Int32.Parse(data);

                HttpContext.Session.SetInt32("secretNumber", secretNumber);


                return View("GuessTheNumber");
            }
            else
            {
                return View("Index");
            }
        }

        private void callback(IAsyncResult requestObj)
        {
            Thread.Sleep(5000);
            HttpWebRequest hwReq2 = (HttpWebRequest)requestObj.AsyncState; 
            
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

                ViewData["hint"] = guess.makeGuess((int)HttpContext.Session.GetInt32("secretNumber"));
                return View("GuessTheNumber");
            }
            else
            {
                return View("GuessTheNumber");
            }
            
        }
    }
}
