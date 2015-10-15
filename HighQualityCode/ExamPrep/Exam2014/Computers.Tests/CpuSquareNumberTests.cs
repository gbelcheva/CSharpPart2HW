namespace Computers.Tests
{
    using Computers.Common.Components;
    using Computers.Common.Components.CPUs;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class CpuSquareNumberTests
    {
        [TestMethod]
        public void ShouldCalculateSquareCorrectly()
        {
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock
                .Setup(x => x.LoadRamValue())
                .Returns(111);

            var cpu = new Cpu32(4);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();

            motherboardMock
                .Verify(x => x.DrawOnVideoCard(It.Is<string>(param => param.Contains("12321"))));
        }


        [TestMethod]
        public void ShouldShowNumberTooLowMessageWhenNumberLessThan0()
        {
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock
                .Setup(x => x.LoadRamValue())
                .Returns(-1);

            var cpu = new Cpu32(4);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();

            motherboardMock
                .Verify(x => x.DrawOnVideoCard(It.Is<string>(param => param == "Number too low.")));
        }

        [TestMethod]
        public void ShouldShowNumberTooHighMessageWhenNumberLargerThan500()
        {
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock
                .Setup(x => x.LoadRamValue())
                .Returns(501);

            var cpu = new Cpu32(4);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();

            motherboardMock
                .Verify(x => x.DrawOnVideoCard(It.Is<string>(param => param == "Number too high.")));
        }
    }
}
