using System;
namespace Delegates.src
{
    public class WriteToConsole
    {
        public delegate void WriteToConsoleDelegate(string text);

        //WriteToConsoleDelegate write1 = new WriteToConsoleDelegate(WriteFirstName);
        //WriteToConsoleDelegate write2 = new WriteToConsoleDelegate(WriteLastName);

        //Multicast
        WriteToConsoleDelegate? writeAll;

        public static event WriteToConsoleDelegate? WritePersonalInfoEvent;
       

        public WriteToConsole()
        {
            //writeAll = write1;
            //writeAll += write2;

            WriteFirstName("Johny from constructor");
            //WriteLastName("Depp");
            
        }

        public void WriteFirstName(string text)
        {
            text.Output();
            NotifiySubscribers(text);
        }

        public void WriteLastName(string text)
        {
            text.Output();
            NotifiySubscribers(text);
        }

        private void NotifiySubscribers(string text)
        {
            // if writePersonalInfoEvent is not null, call delegate
            WritePersonalInfoEvent?.Invoke(text);

        
        }

        
    }
}

