using NUnit.Framework;
using TestFrameworks_Core;

namespace TestFrameworks_XUnit
{
    [TestFixture]
    public class TestFrameworks_NUnit
    {
        [Test]
        public void TestAdd()
        {
            int expected = 10;
            int first = 4;
            int second = 6;

            int actual = Program.Add(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 4, 6)]
        [TestCase(15, 9, 6)]
        [TestCase(-5, 1, -6)]
        public void TestAddMoreRobust(int expected, int first, int second)
        {
            var actual = Program.Add(first, second);

            Assert.AreEqual(expected, actual);
        }
    }
}