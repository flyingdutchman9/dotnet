using System;
namespace Delegates.src
{
    public class Subscriber2
    {
        public Subscriber2(Subscriber1 subscriber1)
        {
            WriteToConsole.WritePersonalInfoEvent += WriteToConsole_writePersonalInfoToConsole;
            //WriteToConsole writeToConsole = new WriteToConsole();

            //writeToConsole.WriteFirstName("Johnny from Subscriber2");
            //writeToConsole.WriteLastName("Depp from Subscriber2");
        }

        void WriteToConsole_writePersonalInfoToConsole(string text)
        {
            "---------------SUBSCRIBER 2------------------------------".Output();
            "Following text was written to the console using delegate:".Output();
            text.Output();
            "---------------------------------------------------------".Output();
        }
    }
}

