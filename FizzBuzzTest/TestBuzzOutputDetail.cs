

using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class TestBuzzOutputDetail
    {

        /// <summary>
        /// To verify Buzz result which returs true when divisble by 5.       
        /// </summary>
        [TestMethod]
        public void TestOuputFizzResult()
        {
            // Arrange
            const int numeratorInput = 5;

            // Setup
            var result = ProcessFizzBuzz.IsDivisibleBy(numeratorInput, ProcessFizzBuzz.BUZZ_NUMBER);

            // Assert
            Assert.IsTrue(result);
        }   

        /// <summary>
        /// To verify Buzz detail with line break when divisble by 5.      
        /// </summary>
        [TestMethod]
        public void TestOuputBuzzDetail()
        {
            // Arrange
            const int startingPoint = 5;
            const int finishingPoint = 5;
            const string expectedOutput = "Buzz\r\n";

            // Setup
            var result = ProcessFizzBuzz.TransformToFizzBuzz(startingPoint, finishingPoint);

            // Assert
            Assert.AreEqual(result, expectedOutput);
        }
    }
}