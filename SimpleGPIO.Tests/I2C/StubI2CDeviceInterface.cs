using SimpleGPIO.I2C;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGPIO.Tests.I2C
{
    public class StubI2CDeviceInterface : II2CDeviceInterface
    {
        public int Address;

        public StubI2CDeviceInterface(int address)
        {
            Address = address;
        }

        public void Dispose()
        {

        }
    }
}
