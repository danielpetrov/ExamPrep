namespace Computers.UI
{
    public interface IComputerFactory
    {
        PersonalComputer CreatePersonalComputer();

        Laptop CreateLaptop();

        Server CreateServer(); 
    }
}
