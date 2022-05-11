using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FireBase
{
    internal class Program
    {
       
        static async Task Main(string[] args)
        {
            string deviceId = "d0LVIJ3FGZuQWQGSDXEu8_:APA91bHFIcoHvkDodqTyFM1G7Vw51s_Usu9FrQbeKTJAturRdmYdoDhyOaaf3kNlFk2wH1Oo6tM3Q2FkCtIAkUPmCQI2wRux_QFt0h1KAN2pMkWxHpZArbamoRvWp_Is0yC4LnTIWGbL";
            var firebaseApp = FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "demofilebase-a876e-firebase-adminsdk-81ae1-218752ea3d.json"))
            });
        
                  // These registration tokens come from the client FCM SDKs.
                  var registrationTokens = new List<string>() { deviceId };
{
   
};
            var message = new MulticastMessage()
            {
                Tokens = registrationTokens,
                Notification = new Notification()
                {
                    Title = "$GOOG up 1.43% on the day",
                    Body = "$GOOG gained 11.80 points to close at 835.67, up 1.43% on the day.",
                },
                Data = new Dictionary<string, string>()
    {
        { "score", "850" },
        { "time", "2:45" },
    },
            };

            var response = await FirebaseMessaging.DefaultInstance.SendMulticastAsync(message);
            if (response.FailureCount > 0)
            {
                var failedTokens = new List<string>();
                for (var i = 0; i < response.Responses.Count; i++)
                {
                    if (!response.Responses[i].IsSuccess)
                    {
                        // The order of responses corresponds to the order of the registration tokens.
                        failedTokens.Add(registrationTokens[i]);
                    }
                }

                Console.WriteLine($"List of tokens that caused failures: {failedTokens}");
            }
        }

       
    }
} 
    

