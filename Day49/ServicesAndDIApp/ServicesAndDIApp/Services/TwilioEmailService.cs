using System;

namespace ServicesAndDIApp.Services
{
    public class TwilioEmailService : IRRDEmailService
    {
        public TwilioEmailService()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TwilioEmail Service Created");
            Console.ResetColor();
        }

        public Task SendEmailAsync(string to, string subject, string body)    
        {
            return Task.Run(() =>
            {
                //real api calls to twilios
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Sending Email via Twilio service {to}-{subject}-{body}");
                Console.ResetColor();
             });
        }
    }
}
