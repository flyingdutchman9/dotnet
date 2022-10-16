using System;
namespace Delegates.src2
{
    public class MessageService
    {
        public MessageService()
        {
        }

        public void onVideoEncoded(object source, MP4Args e)
        {
            Console.WriteLine("Message Service:,Sending an Message {0}", e.mp4.Title);
        }
    }
}

