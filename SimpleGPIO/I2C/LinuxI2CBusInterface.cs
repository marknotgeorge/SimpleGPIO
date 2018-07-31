using SimpleGPIO.OS;
using System.Collections.Generic;

namespace SimpleGPIO.I2C
{
    internal class LinuxI2CBusInterface : II2CBusInterface
    {
        
        private Dictionary<int, II2CDeviceInterface> _devices;

        public LinuxI2CBusInterface()
        {            
            _devices = new Dictionary<int, II2CDeviceInterface>();
        }

        private bool? _enabled;
        public bool Enabled
        {
            get
            {
                return (bool)_enabled;
            }
            set
            {
                _enabled = value;
                //TODO: Enable the bus here...
            }
        }



        public II2CDeviceInterface Device(int address)
        {
            return _devices[address] ??  (_devices[address] = new LinuxI2CDeviceInterface(address, _fileSystem));
        }

        public void Disable()
        {
            Enabled = false;
        }

        public void Dispose()
        {
            Disable();
        }

        public void Enable()
        {
            Enabled = true;
        }
    }
}