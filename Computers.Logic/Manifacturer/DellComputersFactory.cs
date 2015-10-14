namespace Computers.Logic.Manifacturer
{
    using System.Collections.Generic;
    using ComputerTypes;
    using CPUs;
    using HardDriver;
    using VideoCards;

    public class DellComputersFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var ram = new Ram(8);
            var videoCard = new ColorVideoCard();

            var laptop = new Laptop(
                new Cpu32(4, ram, videoCard),
                ram,
                new[] { new SingleHardDriver(1000) },
                videoCard,
                new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(8);
            var videoCard = new ColorVideoCard();
            var pc = new PersonalComputer(
                new Cpu64(4, ram, videoCard),
                ram,
                new[] { new SingleHardDriver(1000) },
                videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(64);
            var videoCard = new MonochromeVideoCard();
            var server = new Server(
                new Cpu64(8, ram, videoCard),
                ram,
                new List<HardDriver> { new RaidArray(new List<HardDriver> { new SingleHardDriver(2000), new SingleHardDriver(2000) }) },
                videoCard);

            return server;
        }
    }
}
