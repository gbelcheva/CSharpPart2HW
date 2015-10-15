namespace Computers.Common.Manufacturers
{
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Computers.Common.Components.HardDrives;
    using Computers.Common.ComputerTypes;
    using Computers.Common.Manufacturers.Contracts;
    
    public class LenovoComputersManufacturer : IComputersManufacturer
    {
        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu64(2),
                new Ram(4),
                new SingleHardDrive(2000),
                new VideoCard() { IsMonochrome = false });

            return pc;
        }

        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu64(2),
                new Ram(16),
                new SingleHardDrive(1000),
                new VideoCard() { IsMonochrome = false },
                new LaptopBattery());

            return laptop;
        }

        public Server CreateServer()
        {
            var server = new Server(
                new Cpu128(2),
                new Ram(8),
                new RaidArray(new List<HardDrive> { new SingleHardDrive(500), new SingleHardDrive(500) }),
                new VideoCard());

            return server;
        }
    }
}
