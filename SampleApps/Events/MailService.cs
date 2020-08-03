using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object sender,VideoEventArgs videoArgs)
        {
            Console.WriteLine($"Sending mail.....{videoArgs.Video.Titile} Encoding is completed");
        }
    }
}