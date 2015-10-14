namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using HardDriver;
    using VideoCards;

    public class Laptop : Computer
    {
        private readonly ILaptopBattery battery;

        internal Laptop(
            CPUs.Cpu cpu,
            IRam ram,
            IEnumerable<HardDriver> hardDrives,
            VideoCard videoCard,
            ILaptopBattery laptopBattery)
            : base(cpu, ram, hardDrives, videoCard)
        {
            this.battery = laptopBattery;
        }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.VideoCard.Draw(string.Format("Battery status: {0}", this.battery.Percentage));
        }
    }
}
