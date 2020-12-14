using System;
using System.Collections.Generic;
using System.Text;

namespace kiosk_system
{
    public interface IScreen
    {
        void Write(string message);
        void WriteLine(string message);
    }
}
