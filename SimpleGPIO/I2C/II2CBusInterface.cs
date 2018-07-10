using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGPIO.I2C
{
    public interface II2CBusInterface: IDisposable
    {
        II2CDeviceInterface Device(int address);

        void Enable();
        void Disable();

    }
}
