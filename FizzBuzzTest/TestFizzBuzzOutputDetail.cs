

using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class TestFizzBuzzOutputDetail
    {

        /// <summary>
        /// To verify FizzBuzz result which returs true when divisble by 15.       
        /// </summary>
        [TestMethod]
        public void TestOuputFizzResult()
        {
            // Arrange
            const int numeratorInput = 15;
            const int denominatorInput =15;

            // Setup
            var result = ProcessFizzBuzz.IsDivisibleBy(numeratorInput, denominatorInput);

            // Assert
            Assert.IsTrue(result);
        }   

        /// <summary>
        /// To verify FizzBuzz detail with line break when divisble by 15.      
        /// </summary>
        [TestMethod]
        public void TestOuputFizzDetail()
        {
            // Arrange
            const int startingPoint = 15;
            const int finishingPoint = 15;
            const string expectedOutput = "FizzBuzz\r\n";

            // Setup
            var result = ProcessFizzBuzz.TransformToFizzBuzz(startingPoint, finishingPoint);

            // Assert
            Assert.AreEqual(result, expectedOutput);
        }
    }
}