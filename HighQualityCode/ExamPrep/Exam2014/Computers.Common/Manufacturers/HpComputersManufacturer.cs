namespace Computers.Common.Manufacturers
{
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Computers.Common.Components.HardDrives;
    using ComputerTypes;
    using Manufacturers.Contracts;

    public class HpComputersManufacturer : IComputersManufacturer
    {
        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu32(2),
                new Ram(2),
                new SingleHardDrive(500),
                new VideoCard() { IsMonochrome = false });

            return pc;
        }

        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu64(2),
                new Ram(4),
                new SingleHardDrive(500),
                new VideoCard() { IsMonochrome = false },
                new LaptopBattery());

            return laptop;
        }

        public Server CreateServer()
        {
            var server = new Server(
                new Cpu32(4),
                new Ram(32),
                new RaidArray(new List<HardDrive> { new SingleHardDrive(1000), new SingleHardDrive(1000) }),
                new VideoCard());

            return server;
        }
    }
}