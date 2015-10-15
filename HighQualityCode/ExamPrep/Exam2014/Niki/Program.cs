namespace Computers
{
    using System;
    using Computers.Common;
    using Computers.Common.ComputerTypes;
    using Computers.Common.Manufacturers;
    using Computers.Common.Manufacturers.Contracts;

    public class Program
    {
        private static PersonalComputer pc;
        private static Laptop laptop;
        private static Server server;

        public static void Main()
        {
            CreateComputers();

            ProcessCommands();
        }

        private static void ProcessCommands()
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command == null)
                {
                    break;
                }

                if (command.StartsWith("Exit"))
                {
                    break;
                }

                var commandParameters = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commandParameters.Length != 2)
                {
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                }

                var commandName = commandParameters[0];
                var commandArgument = int.Parse(commandParameters[1]);

                if (commandName == "Charge")
                {
                    laptop.ChargeBattery(commandArgument);
                }
                else if (commandName == "Process")
                {
                    server.Process(commandArgument);
                }
                else if (commandName == "Play")
                {
                    pc.Play(commandArgument);
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
        }

        private static void CreateComputers()
        {
            var manufacturer = Console.ReadLine();
            IComputersManufacturer computerFactory;

            if (manufacturer == "HP")
            {
                computerFactory = new HpComputersManufacturer();
            }
            else if (manufacturer == "Dell")
            {
                computerFactory = new DellComputersManufacturer();
            }
            else if (manufacturer == "Lenovo")
            {
                computerFactory = new LenovoComputersManufacturer();
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            ManufactureComputers(computerFactory);
        }

        private static void ManufactureComputers(IComputersManufacturer factory)
        {
            pc = factory.CreatePersonalComputer();
            laptop = factory.CreateLaptop();
            server = factory.CreateServer();
        }
    }
}
