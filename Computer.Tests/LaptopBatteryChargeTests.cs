namespace Computer.Tests
{
    using Computers.Logic.LaptopBattery;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LaptopBatteryChargeTests
    {
        [TestMethod]
        public void ChargeShoudAddToPercentageWhenGivenPositiveNumber()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(10);
            Assert.AreEqual(60, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShoudSubstractToPercentageWhenGivenNegativeNumber()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.DefaultBatteryChargeValue;
            battery.Charge(-10);
            Assert.AreEqual(40, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShoudNotSubstractToPercentageWhenGivenNegativeNumberAndPRCis0()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.BatteryMinValue;
            battery.Charge(-10);
            Assert.AreEqual(LaptopBattery.BatteryMinValue, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShoudNotAddToPercentageWhenGivenPositiveNumberAndPrcIs100()
        {
            var battery = new LaptopBattery();
            battery.Percentage = LaptopBattery.BatteryMaxValue;
            battery.Charge(10);
            Assert.AreEqual(LaptopBattery.BatteryMaxValue, battery.Percentage);
        }
    }
}
