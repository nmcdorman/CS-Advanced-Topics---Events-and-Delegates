using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CS_Advanced_Topics___Events_and_Delegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //  1.  Define a delegate
        //  2.  Define an event based on that delegate
        //  3.  Raise the event

        //  1.
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);   // Determines Signature

        //  2.
        public event VideoEncodedEventHandler VideoEncoded; // Past tense since the event happens when finished
                
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            
            OnVideoEncoded(video);
        }

        //  3.
        protected virtual void OnVideoEncoded(Video video) // Starts with "On" and then the name of the event
            // has protected and virtual definitions
        {
            if (VideoEncoded != null)   // If its not null, then there is a subscriber
                VideoEncoded(this, new VideoEventArgs() { Video = video});    // Notify - Notice the empty arguments 

        }

    }
}
