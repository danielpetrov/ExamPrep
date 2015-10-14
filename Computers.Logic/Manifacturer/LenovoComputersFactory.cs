namespace Computers.Logic.Manifacturer
{
    using System;
    using System.Collections.Generic;
    using ComputerTypes;

    public class LenovoComputersFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var ram = new Ram(16);
            var videoCard = new VideoCard() { IsMonochrome = false };

            var laptop = new Laptop(
                new Cpu(2, 64, ram, videoCard),
                ram,
                new[] { new HardDriver(1000, false, 0) },
                videoCard,
                new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(4);
            var videoCard = new VideoCard() { IsMonochrome = true };
            var pc = new PersonalComputer(
                new Cpu(2, 64, ram, videoCard),
                ram,
                new[] { new HardDriver(2000, false, 0) },
                videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(8);
            var videoCard = new VideoCard();
            var server = new Server(
                new Cpu(2, 128, ram, videoCard),
                ram,
                new List<HardDriver> { new HardDriver(0, true, 2, new List<HardDriver> { new HardDriver(500, false, 0), new HardDriver(500, false, 0) }) },
                videoCard);

            return server;
            /*var ram = new Ram(64);
            var videoCard = new VideoCard();
            var server = new Server(
                new Cpu(8, 64, ram, videoCard),
                ram,
                new List<HardDriver> {
                        new HardDriver(0, true, 2, new List<HardDriver> {
                             new HardDriver(2000, false, 0), new HardDriver(2000, false, 0)})
                }, 
                videoCard);

            return server;*/
        }
    }
}
