using FsCheck;
using FsCheck.Xunit;
using Property_Core;
using Xunit;

namespace Property_Tests
{
    public class Property_Tests
    {
        [Property(Verbose = true)]
        public void AddIsCommutative(int first, int second)
        {
            var result1 = Program.Add(first, second);
            var result2 = Program.Add(second, first);

            Assert.Equal(result1, result2);
        }
    }
}
