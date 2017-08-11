using System;

namespace NoteFone.MVC.Controllers{
    public class Settings        {
            public static string AccountSid = Environment.GetEnvironmentVariable("AC3171fb46ddefaa74be1bd03b6647cbfa");
            public static string AuthToken = Environment.GetEnvironmentVariable("fa9fda17605b252b6fcab4b3d3748402");
            public static string MyOwnNumber = Environment.GetEnvironmentVariable("+5511973968824");
            public static string MyTwilioNumber = Environment.GetEnvironmentVariable("+551142004936");

            }
}