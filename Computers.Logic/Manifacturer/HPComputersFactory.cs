namespace Computers.Logic.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using CPUs;
    using ComputerTypes;

    public class HPComputersFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var videoCard = new VideoCard()
            {
                IsMonochrome = false
            };
            var ram = new Ram(4);

            var laptop = new Laptop(
                    new Cpu64(2, ram, videoCard),
                    ram,
                    new[] { new HardDriver(500, false, 0) },
                    videoCard,
                    new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(2);
            var videoCard = new VideoCard() { IsMonochrome = false };
            var pc = new PersonalComputer(
                new Cpu32(2, ram, videoCard),
                ram,
                new[] { new HardDriver(500, false, 0) },
                videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(32);
            var video = new VideoCard();
            var server = new Server(
                new Cpu32(4, ram, video),
                ram,
                new List<HardDriver> { new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(1000, false, 0), new HardDriver(1000, false, 0) }) },
                video);

            return server;
        }
    }
}
