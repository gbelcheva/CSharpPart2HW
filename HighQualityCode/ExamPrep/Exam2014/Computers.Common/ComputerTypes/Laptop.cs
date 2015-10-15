namespace Computers.Common.ComputerTypes
{
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Computers.Common.Components.HardDrives;

    public class Laptop : Computer
    {
        private readonly LaptopBattery battery;

        public Laptop(
        Cpu cpu,
        Ram ram,
        HardDrive hardDrive,
        VideoCard videoCard,
        LaptopBattery battery)
            : base(cpu, ram, hardDrive, videoCard)
        {
            this.battery = battery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);

            VideoCard.Draw(string.Format("Battery status: {0}%", this.battery.Percentage));
        }
    }
}