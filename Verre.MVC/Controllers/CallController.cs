using System;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.TwiML;
using Twilio.Types;
using Twilio.Clients;
using Twilio.Http;

namespace Verre.MVC.Controllers
{
    public class CallController : TwilioController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Receive()
        {
            var twiml = new VoiceResponse();
            
            //return TwiML(twiml.Say("Welcome! You are calling to 2pip2 technology. We are very happy with your contact. Mr. Paulo Perez is our founder and soon you will speak to him.").Dial("+5511947900620"));
            return TwiML(twiml.Say("Hello Will Castilho, your friend Paulo Perez is the best, think in all possibilities, 2.Pi is amazing wait, We will be rich. Wait on momentent in this call and talk about it with him ").Dial("+5511947900620"));
            //return TwiML(twiml.Say("Hello Aecio, your friend Paulo Perez is the best, think in all possibilities, 2.Pi is amazing, We will be rich. Do not hung up! Wait one momentent in this call and talk about it with him ").Dial("+5511973968824"));
        }
        public ActionResult ReceiveCall()
        {
            var twiml = new VoiceResponse();
            //twiml.Record(timeout: 2, transcribe: true);

            return TwiML(twiml.Say("Seja bem vindo ao Portal Two Dot pi ai. Estamos muito felizes com a sua chamada," +
                " Aguarde um instante, " +
                "voce estara sendo atendido por Paulo Perez. ",
                voice: "alice", language: "pt-BR", loop: 1).Dial("+5511947900620",record: "record-from-answer"));

        }
        // POST: MakeCall
        [HttpPost]
        public ActionResult MakeCall(string number)
        {
            TwilioClient.Init("AC3171fb46ddefaa74be1bd03b6647cbfa", "fa9fda17605b252b6fcab4b3d3748402");
            var call = CallResource.Create(
                to: new PhoneNumber(number),
                //to: new PhoneNumber("+351919690199"),
                from: new PhoneNumber("+551142004936"),
                url: new Uri("http://verre.azurewebsites.net/Call/ReceiveCall")
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