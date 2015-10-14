using System;
using System.Collections.Generic;
using Computers.Logic.VideoCards;

namespace Computers.Logic.CPUs
{
    public class Cpu64 : Cpu
    {
        public Cpu64(byte numberOfCores, Ram ram, VideoCard videoCard)
            : base(numberOfCores, ram, videoCard)
        {
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        protected override int GetMaxValue()
        {
            return 1000;
        }
    }
}
