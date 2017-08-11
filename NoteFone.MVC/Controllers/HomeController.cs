using System;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Mvc;
using Twilio.Clients;
using Twilio.Http;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;
using Twilio.Types;

namespace NoteFone.MVC.Controllers
{
    public class HomeController : TwilioController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ReceiveCall()
        {
            var twiml = new VoiceResponse();

             return TwiML(twiml.Say("Hello Tiago, Believe in your friend Paulo Perez, think in all possibilities, it is amazing. Do not hung up! Wait one moment on this call and talk about it with him " ).Dial(" +5511973968824"));
            //return TwiML(twiml.Say("Hello Aguinaldinho and Jonathan, your friend Paulo Perez is the best, think in all possibilities, 2.Pi is amazing wait, We will be rich. Wait on momentent in this call and talk about it with him ").Dial("+5511973968824"));
            //return TwiML(twiml.Say("Hello Aecio, your friend Paulo Perez is the best, think in all possibilities, 2.Pi is amazing, We will be rich. Do not hung up! Wait one momentent in this call and talk about it with him ").Dial("+5511973968824"));

        }
        // POST: MakeCall
        [HttpPost]
        public ActionResult MakeCall(string number) {
            TwilioClient.Init("AC3171fb46ddefaa74be1bd03b6647cbfa", "fa9fda17605b252b6fcab4b3d3748402");
            var call = CallResource.Create(
                to: new PhoneNumber(number),
                //to: new PhoneNumber("+351919690199"),
                from: new PhoneNumber("+551142004936"),
                url: new Uri("http://notefone.azurewebsites.net/Home/ReceiveCall")
                );
            
            return Content(call.Sid);
        }



        [HttpPost]
        public ActionResult ClickToCall(string salesNumber)
        {
            var response = new VoiceResponse();
            response
                .Say("Thanks for contacting our sales department. Our " +
                     "next available representative will take your call.")
                .Dial(salesNumber);
                //.Hangup();
                
            return TwiML(response);

        }
    }
}
