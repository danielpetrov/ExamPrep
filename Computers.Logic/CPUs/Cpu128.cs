using Computers.Logic.VideoCards;

namespace Computers.Logic.CPUs
{
    public class Cpu128 : Cpu
    {
        public Cpu128(byte numberOfCores, Ram ram, VideoCard videoCard)
            : base(numberOfCores, ram, videoCard)
        {
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        protected override int GetMaxValue()
        {
            return 2000;
        }
    }
}
