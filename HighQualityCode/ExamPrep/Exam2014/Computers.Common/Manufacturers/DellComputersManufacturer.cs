namespace Computers.Common.Manufacturers
{
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Computers.Common.Components.HardDrives;
    using ComputerTypes;
    using Manufacturers.Contracts;

    public class DellComputersManufacturer : IComputersManufacturer
    {
        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu64(4),
                new Ram(8),
                new SingleHardDrive(1000),
                new VideoCard() { IsMonochrome = false });

            return pc;
        }

        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu32(4),
                new Ram(8),
                new SingleHardDrive(1000),
                new VideoCard() { IsMonochrome = false },
                new LaptopBattery());

            return laptop;
        }

        public Server CreateServer()
        {
            var server = new Server(
                new Cpu64(8),
                new Ram(64),
                new RaidArray(new List<HardDrive> { new SingleHardDrive(2000), new SingleHardDrive(2000) }),
                new VideoCard());

            return server;
        }
    }
}