﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using SimpleGPIO.I2C;
using SimpleGPIO.OS;

namespace SimpleGPIO.Boards
{
    public static class I2CBusInterfaceFactory
    {
         public static II2CBusInterface NewI2CBus()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return new LinuxI2CBusInterface(FileSystem);

            throw new NotImplementedException($"{GetOSName()} is not yet supported");
        }

        private static FileSystem FileSystem
            => new FileSystem(path => new FileInfoWrapper(path), (fs, path, predicate, action) => new FileWatcher(fs, path, predicate, action));

        private static string GetOSName()
            => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "Windows"
            : (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) ? "OSX"
            : "Unknown OS");
    }
}
