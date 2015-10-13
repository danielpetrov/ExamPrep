namespace Computers.UI.ComputerTypes
{
    using System.Collections.Generic;

    public class Laptop : Computer
    {
        private readonly LaptopBattery battery;

        internal Laptop(
            Cpu cpu,
            Rammstein ram,
            IEnumerable<HardDriver> hardDrives,
            HardDriver videoCard,
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
