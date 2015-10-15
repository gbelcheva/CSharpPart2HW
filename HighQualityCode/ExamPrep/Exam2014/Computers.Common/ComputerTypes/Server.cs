namespace Computers.Common.ComputerTypes
{
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Computers.Common.Components.HardDrives;

    public class Server : Computer
    {
        public Server(
        Cpu cpu,
        Ram ram,
        HardDrive hardDrive,
        VideoCard videoCard)
            : base(cpu, ram, hardDrive, videoCard)
        {
            this.VideoCard.IsMonochrome = true;
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);

            // TODO: Fix it
            Cpu.SquareNumber();
        }
    }
}