namespace Computers.Common.Manufacturers.Contracts
{
    using ComputerTypes;

    public interface IComputersManufacturer
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreateLaptop();

        Server CreateServer();
    }
}
