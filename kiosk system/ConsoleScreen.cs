using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public class ConsoleScreen : IScreen
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
