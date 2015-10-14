﻿namespace Computers.Logic.Manifacturer
{
    using System.Collections.Generic;
    using ComputerTypes;
    using CPUs;
    using HardDriver;
    using VideoCards;

    public class HPComputersFactory : IComputerFactory
    {
        public Laptop CreateLaptop()
        {
            var videoCard = new ColorVideoCard();
            var ram = new Ram(4);

            var laptop = new Laptop(
                    new Cpu64(2, ram, videoCard),
                    ram,
                    new[] { new SingleHardDriver(500) },
                    videoCard,
                    new LaptopBattery());

            return laptop;
        }

        public PersonalComputer CreatePersonalComputer()
        {
            var ram = new Ram(2);
            var videoCard = new ColorVideoCard();
            var pc = new PersonalComputer(
                new Cpu32(2, ram, videoCard),
                ram,
                new[] { new SingleHardDriver(500) },
                videoCard);

            return pc;
        }

        public Server CreateServer()
        {
            var ram = new Ram(32);
            var video = new MonochromeVideoCard();
            var server = new Server(
                new Cpu32(4, ram, video),
                ram,
                new List<HardDriver> { new RaidArray(new List<HardDriver> { new SingleHardDriver(1000), new SingleHardDriver(1000) }) }, 
                video);

            return server;
        }
    }
}
