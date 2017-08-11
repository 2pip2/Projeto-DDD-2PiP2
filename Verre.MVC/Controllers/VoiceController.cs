using System.Configuration;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Twilio.TwiML;

namespace Verre.MVC.Controllers
{
    [Authorize]
  public class VoiceController : Controller
  {
    [HttpGet]
    public ActionResult Index(string to)
    {
      var callerId = ConfigurationManager.AppSettings["TwilioCallerId"];

      var response = new VoiceResponse();
      if (!string.IsNullOrEmpty(to))
      {
        var dial = new Dial(callerId: callerId);
        // wrap the phone number or client name in the appropriate TwiML verb
        // by checking if the number given has only digits and format symbols
        if (Regex.IsMatch(to, "^[\\d\\+\\-\\(\\) ]+$"))
        {
          dial.Number(to);
        }
        else
        {
          dial.Client(to);
        }
        response.Dial(dial);
      }
      else
      {
        response.Say("Obrigado pela ligação!");
      }
      return Content(response.ToString(), "text/xml");
    }
  }
}