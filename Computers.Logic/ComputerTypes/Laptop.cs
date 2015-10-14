namespace Computers.Logic.ComputerTypes
{
    using System.Collections.Generic;
    using VideoCards;

    public class Laptop : Computer
    {
        private readonly LaptopBattery battery;

        internal Laptop(
            CPUs.Cpu cpu,
            Ram ram,
            IEnumerable<HardDriver> hardDrives,
            VideoCard videoCard,
            LaptopBattery laptopBattery)
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
