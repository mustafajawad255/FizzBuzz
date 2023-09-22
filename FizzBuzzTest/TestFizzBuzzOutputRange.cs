

using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class TestFizzBuzzOutputRange
    {
        /// <summary>
        /// To verify the number of lines as expected to number of output lines.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzzRangeCount()
        {
            // Arrange
            const int startingPoint = 1;
            const int finishingPoint = 100;
            const int expectedOutput = 100;

            // Setup
            var result = ProcessFizzBuzz.TransformToFizzBuzz(startingPoint, finishingPoint);

            // Assert
            Assert.AreEqual(result.Split('\n').Length - 1, expectedOutput);
        }

        /// <summary>
        /// To verify the FizzBuzz output from 1 to 30, literal output with line breaks.
        /// </summary>
        [TestMethod]
        public void TestFizzBuzzRangeLiteralOutput()
        {
            // Arrange
            const int startingPoint = 1;
            const int finishingPoint = 30;
            const string expected = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8\r\nFizz\r\nBuzz" +
                "\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz\r\n16\r\n17\r\nFizz\r\n19\r\nBuzz\r\nFizz" +
                "\r\n22\r\n23\r\nFizz\r\nBuzz\r\n26\r\nFizz\r\n28\r\n29\r\nFizzBuzz\r\n";

            // Setup
            var result = ProcessFizzBuzz.TransformToFizzBuzz(startingPoint, finishingPoint);

            // Assert
            Assert.AreEqual(result, expected);
        }       
    }
}