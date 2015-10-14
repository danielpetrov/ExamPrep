namespace Computers.Logic.Manifacturer
{
    using Computers.Logic.ComputerTypes;

    public interface IComputerFactory
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreateLaptop();

        Server CreateServer(); 
    }
}
