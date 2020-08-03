using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
       var video=new Video(){Titile = "Iron Man"};
       var videoEncoder=new VideoEncoder();
       var mailService=new MailService();
       var smsService=new SmsService();
       videoEncoder.VideoEnCoded += mailService.OnVideoEncoded;
       videoEncoder.VideoEnCoded += smsService.OnVideoEncoded;
       videoEncoder.Encode(video);
       Console.ReadLine();
        }
    }
}
