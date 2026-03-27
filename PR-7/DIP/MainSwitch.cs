using PR_7.DIP.Interfaces;

namespace PR_7.DIP
{
    internal class MainSwitch
    {
        public void Operate(ISwitch device) // Main switch , high level module, this doesnt depend on device. 
        {
            device.TurnOn();
            device.TurnOff();
        }
    }
}
