namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using VideoCards;
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
            
        }

        public void Process(int data)
        {
            this.Ram.SaveValue(data);
            //// TODO: Fix it
            this.Cpu.SquareNumber();
        }
    }
}
