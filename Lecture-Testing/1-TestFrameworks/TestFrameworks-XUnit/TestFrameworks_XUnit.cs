using TestFrameworks_Core;
using Xunit;

namespace TestFrameworks_XUnit
{
    public class TestFrameworks_XUnit
    {
        [Fact]
        public void TestAdd()
        {
            int expected = 10;
            int first = 4;
            int second = 6;

            int actual = Program.Add(first, second);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 4, 6)]
        [InlineData(15, 9, 6)]
        [InlineData(-5, 1, -6)]
        public void TestAddMoreRobust(int expected, int first, int second)
        {
            var actual = Program.Add(first, second);

            Assert.Equal(expected, actual);
        }
    }
}