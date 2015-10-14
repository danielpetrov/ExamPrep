namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using CPUs;
    using HardDriver;
    using VideoCards;

    public class Server : Computer
    {
        internal Server(
            Cpu cpu,
            Ram ram,
            IEnumerable<HardDriver> hardDrives,
            VideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);
            this.Cpu.SquareNumber();
        }
    }
}
