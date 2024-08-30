using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Represents Operations Test
    /// </summary>
    [TestFixture]
    public class OperationsTest
    {
        /// <summary>
        /// Test for Add method
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        [Test]
        public void isCorrect(
            [Values(68, 23, -4, 53, -7, 12, 55, 7, -68, -82)] int a,
            [Values(986, 133, 153, 8, 515, 998, 182, 932, 307, 616)] int b)
        {
            int testSum = Operations.Add(a, b);
            Assert.That(testSum == (a+b));
        }

        /// <summary>
        /// Add min and max values
        /// </summary>
        [Test]
        public void minMax()
        {
            int a = int.MinValue;
            int b = int.MaxValue;
            int testSum = Operations.Add(a, b);
            Assert.That(testSum == (a + b));
        }
    }
}