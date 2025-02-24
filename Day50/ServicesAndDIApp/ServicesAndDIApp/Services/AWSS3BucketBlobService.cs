using System;

namespace ServicesAndDIApp.Services
{
    public class AWSS3BucketBlobService : IRRDBlobService
    {
        public AWSS3BucketBlobService()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AWS S3 Bucket Blob Service Created");
            Console.ResetColor();
        }

        public Task Log(string body)    
        {
            return Task.Run(() =>
            {
                //real api calls to twilios
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Hi this is AWS service-{body}");
                Console.ResetColor();
             });
        }
    }
}
