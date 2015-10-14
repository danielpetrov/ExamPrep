namespace Computer.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Computers.Logic.CPUs;
    using Computers.Logic.Motherboard;
    using Moq;

    [TestClass]
    public class CPUSqareNumberTests
    {
        [TestMethod]
        public void SqaureNumberShoudOutputCorrectValues()
        {
            Cpu32 cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(123);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param.Contains("15129"))));
        }

        [TestMethod]
        public void SqaureNumberShoudThrowErrorWhenValueIsLessThanZero()
        {
            Cpu32 cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(-1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param == Cpu.NumberTooLowMessage)));
        }

        [TestMethod]
        public void SqaureNumberShoudThrowErrorWhenValueIsMoreThanMax()
        {
            Cpu32 cpu = new Cpu32(4);
            var motherboardMock = new Mock<IMotherboard>();
            motherboardMock.Setup(x => x.LoadRamValue()).Returns(Cpu32.MaxValue + 1);
            cpu.AttachTo(motherboardMock.Object);
            cpu.SquareNumber();
            motherboardMock.Verify(x => x.DrawOnVideoCard(
                It.Is<string>(param => param == Cpu.NumberTooHighMessage)));
        }
    }
}
