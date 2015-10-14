namespace Computers.Logic.Manifacturer
{
    using System.Collections.Generic;
    using ComputerTypes;
    using CPUs;
    using HardDriver;
    using VideoCards;

    public class LenovoComputersFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var ram = new Ram(16);
            var videoCard = new ColorVideoCard();

            var laptop = new Laptop(
                new Cpu64(2, ram, videoCard),
                ram,
                new[] { new SingleHardDriver(1000) },
                videoCard,
                new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(4);
            var videoCard = new ColorVideoCard();
            var pc = new PersonalComputer(
                new Cpu64(2, ram, videoCard),
                ram,
                new[] { new SingleHardDriver(2000) },
                videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(8);
            var videoCard = new MonochromeVideoCard();
            var server = new Server(
                new Cpu128(2, ram, videoCard),
                ram,
                new List<HardDriver> { new RaidArray(new List<HardDriver> { new SingleHardDriver(500), new SingleHardDriver(500) }) }, 
                videoCard);

            return server;
        }
    }
}
