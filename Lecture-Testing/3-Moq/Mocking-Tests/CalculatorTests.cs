using Mocking_Core;
using Moq;
using Xunit;

namespace Mocking_Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(10, 4, 6)]
        public void TestAddAndVerifySaveWasCalled(int expected, int first, int second)
        {
            var mockSaveable = new Mock<ISaveable>();
            var calculator = new Calculator(mockSaveable.Object);

            int actual = calculator.AddWithSave(first, second);

            Assert.Equal(expected, actual);
            mockSaveable.Verify(x => x.Save(It.IsAny<string>()), Times.Once);
        }
    }
}
