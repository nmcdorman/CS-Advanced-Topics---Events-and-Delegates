using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Advanced_Topics___Events_and_Delegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a message..." + args.Video.Title);
        }
    }
}
