using System;

namespace Delegates.PhotoProcessingTut
{
    public class PhotoProcessor
    {
       // public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string url,Action<Photo> filterHandler)
        { 
            
            var photo = PhotoUtility.Load("url");
            filterHandler(photo);
        }

    }
}