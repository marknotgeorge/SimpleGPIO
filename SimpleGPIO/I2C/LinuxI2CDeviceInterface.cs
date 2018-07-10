using System;
using SimpleGPIO.OS;

namespace SimpleGPIO.I2C
{
	public class LinuxI2CDeviceInterface : II2CDeviceInterface
	{
		private readonly int _address;
		private readonly IFileSystem _fileSystem;

		public LinuxI2CDeviceInterface(int address, IFileSystem fileSystem)
		{
			this._address = address;
			this._fileSystem = fileSystem;
		}

        public void Dispose()
        {
            
        }
    }
}

	