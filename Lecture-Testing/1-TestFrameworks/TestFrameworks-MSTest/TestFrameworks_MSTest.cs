using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFrameworks_Core;

namespace TestFrameworks_MSTest
{
    [TestClass]
    public class TestFrameworks_MSTest
    {
        [TestMethod]
        public void TestAdd()
        {
            int expected = 10;
            int first = 4;
            int second = 6;

            int actual = Program.Add(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(10, 4, 6)]
        [DataRow(15, 9, 6)]
        [DataRow(-5, 1, -6)]
        public void TestAddMoreRobust(int expected, int first, int second)
        {
            int actual = Program.Add(first, second);

            Assert.AreEqual(expected, actual);
        }
    }
}
