using Computers.Logic.VideoCards;

namespace Computers.Logic.CPUs
{
    public class Cpu32 : Cpu
    {
        public Cpu32(byte numberOfCores, Ram ram, VideoCard videoCard)
            : base(numberOfCores, ram, videoCard)
        {
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        protected override int GetMaxValue()
        {
            return 500;
        }
    }
}
