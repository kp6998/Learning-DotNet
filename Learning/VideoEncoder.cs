using Learning.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    internal class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(1000);

            OnVideoEncoded(video);
        }
        protected void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
    internal class MailService
    {
        public void OnVideoEncode(object sender, EventArgs e)
        {
            Console.WriteLine("MailService: Sending mail...");
        }
    }
    internal class MessageService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            Console.WriteLine("MessageService: Sending message...");
        }
    }
}
