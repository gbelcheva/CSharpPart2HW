namespace Computers.Tests
{
    using System;
    using System.Collections.Generic;
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System.Linq;

    [TestClass]
    public class CpuRandTests
    {
        [TestMethod]
        public void ShouldGenrateIntegerNumberInGivenRange()
        {
            var motherboardMock = new Mock<IMotherboard>();

            var cpu = new Cpu32(4);
            cpu.AttachTo(motherboardMock.Object);

            for (int i = 0; i < 100; i++)
            {
                cpu.Rand(1, 10);
                motherboardMock
                    .Verify(x => x.SaveRamValue(It.Is<int>(param => 1 <= param && param < 11)));
            }
        }

        [TestMethod]
        public void ShouldGenrateRandomNumberWithCorrectMinValue()
        {
            var motherboardMock = new Mock<IMotherboard>();

            var cpu = new Cpu32(4); 
            cpu.AttachTo(motherboardMock.Object);

            var currentMin = int.MaxValue;

            for (int i = 0; i < 100; i++)
            {
                cpu.Rand(1, 10);
                motherboardMock
                    .Setup(x => x.SaveRamValue(It.IsAny<int>()))
                    .Callback<int>(param => currentMin = Math.Min(param, currentMin));
            }

            int expected = 1;
            int actual = currentMin;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGenrateRandomNumberWithCorrectMaxValue()
        {
            var motherboardMock = new Mock<IMotherboard>();

            var cpu = new Cpu32(4);
            cpu.AttachTo(motherboardMock.Object);

            var currentMax = int.MinValue;

            for (int i = 0; i < 100; i++)
            {
                cpu.Rand(1, 10);
                motherboardMock
                    .Setup(x => x.SaveRamValue(It.IsAny<int>()))
                    .Callback<int>(param => currentMax = Math.Max(param, currentMax));
            }

            int expected = 10;
            int actual = currentMax;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldGenrateRandomNumberWithCorrectAvgValue()
        {
            var motherboardMock = new Mock<IMotherboard>();

            var cpu = new Cpu32(4);
            cpu.AttachTo(motherboardMock.Object);

            var allNumbers = new HashSet<double>();

            for (int i = 0; i < 100; i++)
            {
                cpu.Rand(1, 10);
                motherboardMock
                    .Setup(x => x.SaveRamValue(It.IsAny<int>()))
                    .Callback<int>(param => allNumbers.Add(param));
            }

            double expected = 5;
            double actual = Math.Floor(allNumbers.Average(x => x));

            Assert.AreEqual(expected, actual);
        }
    }
}
