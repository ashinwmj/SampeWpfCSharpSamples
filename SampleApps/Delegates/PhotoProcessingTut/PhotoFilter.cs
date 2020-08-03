using System;

namespace Delegates.PhotoProcessingTut
{
    public class PhotoFilter
    {
        public void ApplyForestFilter(Photo photo)
        {
            Console.WriteLine("Applied forest filter");
        }
        public void ApplyBlackAndWhite(Photo photo)
        {
            Console.WriteLine("Applied Black and White filter");
        }
    }
}