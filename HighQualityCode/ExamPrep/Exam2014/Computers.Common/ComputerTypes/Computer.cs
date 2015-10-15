namespace Computers.Common.ComputerTypes
{
    using System;
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Computers.Common.Components.HardDrives;

    public abstract class Computer
    {
        private Motherboard motherboard;

        internal Computer(
            Cpu cpu,
            Ram ram,
            HardDrive hardDrive,
            VideoCard videoCard)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrive = hardDrive;
            this.VideoCard = videoCard;
            this.motherboard = new Motherboard(this.Cpu, this.Ram, this.VideoCard);
        }

        protected HardDrive HardDrive { get; set; }

        protected VideoCard VideoCard { get; set; }

        protected Cpu Cpu { get; set; }

        protected Ram Ram { get; set; }
    }
}