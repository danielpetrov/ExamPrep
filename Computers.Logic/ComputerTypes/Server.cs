﻿namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using CPUs;

    public class Server : Computer
    {
        internal Server(
            Cpu cpu,
            Ram ram,
            IEnumerable<HardDriver> hardDrives,
            VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.VideoCard.IsMonochrome = true;
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);
            //// TODO: Fix it
            this.Cpu.SquareNumber();
        }
    }
}
