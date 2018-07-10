using SimpleGPIO.I2C;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGPIO.Tests.I2C
{
    public class StubI2CBusInterface : II2CBusInterface
    {
        Dictionary<int, StubI2CDeviceInterface> _devices;

        public StubI2CBusInterface()
        {
            _devices = new Dictionary<int, StubI2CDeviceInterface>();
        }

        public bool Enabled = false;


        public II2CDeviceInterface Device(int address)
        {
            return _devices[address] ?? (_devices[address] = new StubI2CDeviceInterface(address));
        }

        public void Disable()
        {
            Enabled = false;
        }

        public void Dispose()
        {
            
        }

        public void Enable()
        {
            Enabled = true;
        }
    }
}
