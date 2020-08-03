using System;

namespace Events
{
    public class SmsService
    {
        public void OnVideoEncoded(object sender,VideoEventArgs videoEventArgs)
        {
            Console.WriteLine($"Sending SMS.....{videoEventArgs.Video.Titile} Encoding is completed");
        }
    }
}