using System;
using System.Collections.Generic;
using System.Text;
using TheNextCar.Model;

namespace TheNextCar.Controller
{
    class AccubatteryController
    {
        private Accubattery accubattery;
        private OnPowerChanged callBackOnPowerChanged;

        public AccubatteryController(OnPowerChanged callBackOnPowerChanged)
        {
            this.accubattery = new Accubattery(12);
            this.callBackOnPowerChanged = callBackOnPowerChanged;
        }

        public bool accubatteryIsOn()
        {
            return this.accubattery.isOn();
        }

        public void turnOn()
        {
            this.accubattery.turnOn();
            this.callBackOnPowerChanged.OnPowerChangedStatus("ON", "power is on");
        }

        public void turnOff()
        {
            this.accubattery.turnOff();
            this.callBackOnPowerChanged.OnPowerChangedStatus("OFF", "power is off");

        }
    }
    interface OnPowerChanged
    {
        void OnPowerChangedStatus(string value, string message);
    }
}