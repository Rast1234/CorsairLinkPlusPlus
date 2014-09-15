﻿using CorsairLinkPlusPlus.Driver.Node;
using System;

namespace CorsairLinkPlusPlus.Driver.Sensor
{
    public class CorsairThermistor : CorsairSensor
    {
        internal CorsairThermistor(CorsairLinkDevice device, int id)
            : base(device, id)
        {

        }

        public override string GetSensorType()
        {
            return "Temp";
        }

        public override double GetValue()
        {
            return device.GetTemperatureDegC(id);
        }

        public override string GetUnit()
        {
            return "°C";
        }
    }
}
