using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
      //  public delegate void VideoEncoderEventHandler(object sender, VideoEventArgs args);
     //   public event VideoEncoderEventHandler VideoEnCoded;
     public EventHandler<VideoEventArgs> VideoEnCoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Video Encoding started");
            Thread.Sleep(3000);
            Console.WriteLine("Video Encoding completed");
            OnVideoEncoded(video);
        }

        public void OnVideoEncoded(Video video)
        {
            VideoEnCoded?.Invoke(this,new VideoEventArgs() {Video = video});
        }
    }
}