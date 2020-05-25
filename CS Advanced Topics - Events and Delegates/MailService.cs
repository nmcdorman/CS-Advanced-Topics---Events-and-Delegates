using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Advanced_Topics___Events_and_Delegates
{
    public class MailService
    {
        // Sends an email when video has been encoded
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
        }
    }
}
