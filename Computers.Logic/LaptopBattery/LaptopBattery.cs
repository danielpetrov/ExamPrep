namespace Computers.Logic.LaptopBattery
{
    public class LaptopBattery : ILaptopBattery
    {
        public const int BatteryMinValue = 0;
        public const int BatteryMaxValue = 100;
        public const int DefaultBatteryChargeValue = BatteryMaxValue / 2;

        public LaptopBattery()
        {
            this.Percentage = DefaultBatteryChargeValue;
        }

        public int Percentage { get; set; }

        public void Charge(int percentage)
        {
            this.Percentage += percentage;
            if (this.Percentage > BatteryMaxValue)
            {
                this.Percentage = BatteryMaxValue;
            }

            if (this.Percentage < BatteryMinValue)
            {
                this.Percentage = BatteryMinValue;
            }
        }
    }
}
