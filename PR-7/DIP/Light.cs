using PR_7.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PR_7.DIP
{
    internal class Light : ISwitch
    {
        public void TurnOff()
        {
            Console.WriteLine("Light is Off..");
        }

        public void TurnOn()
        {
            Console.WriteLine("Light is Onn..");
        }
    }
}
