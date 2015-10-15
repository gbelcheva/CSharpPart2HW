namespace Computers.Tests
{
    using System;
    using Computers.Common.Components;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LaptopBatteryChargeTests
    {
        [TestMethod]
        public void ShouldChargeWithCorrectAmount()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(10);

            int actual = battery.Percentage;

            int expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldNotChargeOver100()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(100);

            int actual = battery.Percentage;

            int expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldNotDischargeBelow0()
        {
            var battery = new LaptopBattery();
            battery.Percentage = 50;
            battery.Charge(-100);

            int actual = battery.Percentage;

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}
