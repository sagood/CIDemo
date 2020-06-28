using Xunit;

namespace MathLibrary.Tests
{
    public class UnitTest
    {
        [Fact]
        public void AddTest()
        {
            int a = 1, b = 2;
            Assert.Equal(3, Math.Add(a, b));
        }
    }
}
