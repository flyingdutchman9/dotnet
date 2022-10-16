using System;
namespace Delegates.src2
{
    public class MailService
    {
        public MailService()
        {
        }

        public void onVideoEncoded(object source, MP4Args e)
        {
            Console.WriteLine("Mail Service:,Sending an email {0}", e.mp4.Title);
        }
    }
}

