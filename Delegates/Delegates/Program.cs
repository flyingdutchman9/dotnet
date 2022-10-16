using Delegates.src;
using Delegates.src2;
using Delegates.SrcAsync;

Main();
//Subscriber2 subscriber2 = new Subscriber2(new Subscriber1());
static void Main()
{
    new AsyncTest().StartAsyncTest();
    return;// Later...
    var video = new MP4() { Title = "Eminem" };
    var videoEncoder = new MP4EncoderNew();

    var mailService = new MailService();
    var messageService = new MessageService();

    //videoEncoder.mp4Encoded += mailService.onVideoEncoded;
    //videoEncoder.mp4Encoded += messageService.onVideoEncoded;
    
    videoEncoder.Encode(video);
    Console.ReadKey();
}