using System;
namespace Delegates.src2
{
    public class MP4EncoderNew
    {
        public EventHandler? mp4Encoded;

        public void Encode(MP4 video)
        {
            Console.WriteLine("Encoding MP4");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        public void OnVideoEncoded(MP4 video)
        {
            if (mp4Encoded != null)
            {
                mp4Encoded(this, new MP4Args() { mp4 = video });
            }
        }
    }
}

