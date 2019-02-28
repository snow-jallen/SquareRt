using NUnit.Framework;

namespace SquareRt.Core.Tests
{
    [TestFixture]
    public class SquareRtCalculatorTests
    {
        ISquareRtCalculator calc;

        [SetUp]
        public void SetUp()
        {
            // Arrange
            calc = new SquareRtCalculator();
        }

        [Test]
        public void Calculate_4_Returns2()
        {
            // Act
            var squareRoot = calc.Calculate(4);
            // Assert
            Assert.AreEqual(2, squareRoot);
        }
    }
}