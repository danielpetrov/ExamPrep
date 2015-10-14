namespace Computers.Logic.Manifacturer
{
    using System.Collections.Generic;
    using ComputerTypes;
    using CPUs;
    using HardDriver;
    using LaptopBattery;
    using VideoCards;

    public class LenovoComputersFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu64(2),
                new Ram(16),
                new[] { new SingleHardDriver(1000) },
                new ColorVideoCard(),
                new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu64(2),
                new Ram(4),
                new[] { new SingleHardDriver(2000) },
                new ColorVideoCard());

            return pc;
        }

        public Server CreateServer()
        {
            var server = new Server(
                new Cpu128(2),
                new Ram(8),
                new List<HardDriver> { new RaidArray(new List<HardDriver> { new SingleHardDriver(500), new SingleHardDriver(500) }) },
                new MonochromeVideoCard());

            return server;
        }
    }
}
