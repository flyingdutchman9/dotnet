using System;
namespace Delegates.src
{
    public class Subscriber1
    {
        public Subscriber1()
        {
            WriteToConsole.WritePersonalInfoEvent += WriteToConsole_writePersonalInfoToConsole;
            WriteToConsole writeToConsole = new WriteToConsole();

            writeToConsole.WriteFirstName("Johnny from Subscriber1");
            writeToConsole.WriteLastName("Depp from Subscriber1");
        }

        void WriteToConsole_writePersonalInfoToConsole(string text)
        {
            "---------------------SUBSCRIBER 1------------------------".Output();
            "Following text was written to the console using delegate:".Output();
            text.Output();
            "---------------------------------------------------------".Output();
        }
    }
}

