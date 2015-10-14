namespace Computers.Logic.Manifacturer
{
    using System.Collections.Generic;
    using ComputerTypes;
    using CPUs;
    using HardDriver;
    using LaptopBattery;
    using VideoCards;

    public class DellComputersFactory : IComputerFactory
    {
        public const string Name = "Dell";

        public Laptop CreateLaptop()
        {
            var laptop = new Laptop(
                new Cpu32(4),
                new Ram(8),
                new[] { new SingleHardDriver(1000) },
                new ColorVideoCard(),
                new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var pc = new PersonalComputer(
                new Cpu64(4),
                new Ram(8),
                new[] { new SingleHardDriver(1000) },
                new ColorVideoCard());

            return pc;
        }

        public Server CreateServer()
        {
            var server = new Server(
                new Cpu64(8),
                new Ram(64),
                new List<HardDriver> { new RaidArray(new List<HardDriver> { new SingleHardDriver(2000), new SingleHardDriver(2000) }) },
                new MonochromeVideoCard());

            return server;
        }
    }
}
