// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Messaging.V1.Service;


class Example
{
    static void Main (string[] args)
    {
      // Find your Account SID and Auth Token at twilio.com/console
      const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
      const string authToken = "your_auth_token";
      const string pathServiceSid = "MG2172dd2db502e20dd981ef0d67850e1a";
      const string friendlyName = "My company";

      TwilioClient.Init(accountSid, authToken);

      var alphaSender = AlphaSenderResource.Create(pathServiceSid, friendlyName);

      Console.WriteLine(alphaSender.Sid);
    }
}
