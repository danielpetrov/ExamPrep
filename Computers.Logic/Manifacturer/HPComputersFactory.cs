namespace Computers.Logic.Manifacturer
{
    using System.Collections.Generic;
    using ComputerTypes;
    using CPUs;
    using HardDriver;
    using LaptopBattery;
    using VideoCards;

    public class HPComputersFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                    new Cpu64(2),
                    new Ram(4),
                    new[] { new SingleHardDriver(500) },
                    new ColorVideoCard(),
                    new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu32(2),
                new Ram(2),
                new[] { new SingleHardDriver(500) },
                new ColorVideoCard());

            return pc;
        }

        public Server CreateServer()
        {
            var server = new Server(
                new Cpu32(4),
                new Ram(32),
                new List<HardDriver> { new RaidArray(new List<HardDriver> { new SingleHardDriver(1000), new SingleHardDriver(1000) }) },
                new MonochromeVideoCard());

            return server;
        }
    }
}
