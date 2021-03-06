﻿using System;
using SimpleGPIO.IO;
using SimpleGPIO.Power;

namespace SimpleGPIO.GPIO
{
    public interface IPinInterface : IDisposable
    {
        IOMode IOMode { get; set; }
        Direction Direction { get; set; }
        
        IPowerMode PowerMode { get; set; }
        PowerValue Power { get; set; }
        Voltage Voltage { get; set; }

        void Enable();
        void Disable();
        
        void TurnOn();
        void TurnOff();
        void Toggle();

        void Toggle(double hz, TimeSpan duration);
        void Toggle(double hz, ulong iterations);
        void OnPowerOn(Action action);
        void OnPowerOff(Action action);
        void OnPowerChange(Action action);
    }
}
