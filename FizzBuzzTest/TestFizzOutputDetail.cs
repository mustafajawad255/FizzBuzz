

using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class TestFizzOutputDetail
    {

        /// <summary>
        /// To verify Fizz result which returs true when divisble by 3.       
        /// </summary>
        [TestMethod]
        public void TestOuputFizzResult()
        {
            // Arrange
            const int numeratorInput = 3;
            const int denominatorInput = 3;

            // Setup
            var result = ProcessFizzBuzz.IsDivisibleBy(numeratorInput, denominatorInput);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// To verify Fizz detail with line break when divisble by 3.      
        /// </summary>
        [TestMethod]
        public void TestOuputFizzDetail()
        {
            // Arrange
            const int startingPoint = 3;
            const int finishingPoint = 3;
            const string expectedOutput = "Fizz\r\n";

            // Setup
            var result = ProcessFizzBuzz.TransformToFizzBuzz(startingPoint, finishingPoint);

            // Assert
            Assert.AreEqual(result, expectedOutput);
        }
    }
}