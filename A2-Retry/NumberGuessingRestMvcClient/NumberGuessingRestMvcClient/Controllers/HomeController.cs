using NumberGuessingMvcClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NumberGuessingRestMvcClient.Controllers
{
    public class HomeController : AsyncController
    {
       

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

                Session["secretNumber"] =  secretNumber;


                return View("GuessTheNumber");
            }
            else
            {
                return View("Index");
            }
        }

        

        public ActionResult GuessNumber(Guess guess)
        {
            if (ModelState.IsValid)
            {
                if (Session["attempts"] == null)
                {
                    Session["attempts"] = 1;
                }
                else
                {
                    Session["attempts"] = (Int32.Parse((string)Session["attempts"]) + 1);
                }

                ViewData["hint"] = guess.makeGuess(Int32.Parse((string)Session["secretNumber"]));
                return View("GuessTheNumber");
            }
            else
            {
                return View("GuessTheNumber");
            }

        }
    }
}