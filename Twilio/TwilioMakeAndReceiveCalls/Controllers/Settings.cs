using System;

namespace TwilioMakeAndReceiveCalls.Controllers
{
    public static class Settings
    {
        public static string AccountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        public static string AuthToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
        public static string MyOwnNumber = Environment.GetEnvironmentVariable("MY_NUMBER");
        public static string MyTwilioNumber = Environment.GetEnvironmentVariable("TWILIO_NUMBER");
    }
}