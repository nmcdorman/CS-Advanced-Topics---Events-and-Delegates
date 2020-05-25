using System;
using System.Reflection;

namespace CS_Advanced_Topics___Events_and_Delegates
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();      //  publisher
            var mailService = new MailService();        //  subscriber
            var messageService = new MessageService();  //  subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;    // Subscribing - register a handler
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // Subscribing - register a handler
            videoEncoder.Encode(video);            
        }
    }
}
