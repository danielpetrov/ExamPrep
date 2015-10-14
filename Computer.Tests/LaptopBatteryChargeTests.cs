namespace Computer.Tests
{
    using Computers.Logic;
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
            battery.Percentage = 50;
            battery.Charge(-10);
            Assert.AreEqual(40, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShoudNotSubstractToPercentageWhenGivenNegativeNumberAndPRCis0()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 1;
            battery.Charge(-10);
            Assert.AreEqual(0, battery.Percentage);
        }

        [TestMethod]
        public void ChargeShoudNotAddToPercentageWhenGivenPositiveNumberAndPrcIs100()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 100;
            battery.Charge(10);
            Assert.AreEqual(100, battery.Percentage);
        }
    }
}
