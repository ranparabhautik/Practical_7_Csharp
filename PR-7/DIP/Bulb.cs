using PR_7.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PR_7.DIP
{
    internal class Bulb : ISwitch
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb is onn..");
        }
        public void TurnOff()
        {
            Console.WriteLine("Bulb is off..");
        }
    }
}
