using System.Text;

namespace FizzBuzz
{
    public static class ProcessFizzBuzz
    {
        public static string FIZZ = "Fizz";
        public static string BUZZ = "Buzz";
        public static string FIZZ_BUZZ = "FizzBuzz";
        public static int FIZZ_NUMBER = 3;
        public static int BUZZ_NUMBER = 5;
        public static int FIZZ_BUZZ_NUMBER = FIZZ_NUMBER * BUZZ_NUMBER;

        /// <summary>
        /// Writing a program that prints the numbers from 1 to 100, with each on a new line.
        /// For multiples of 3, instead of printing the number, print “Fizz”; for multiples of five,
        /// print “Buzz”; for numbers that are multiples of both 3 and 5, print “FizzBuzz”.
        /// </summary>
        /// <param name="startingPoint"></param>
        /// <param name="finishingPoint"></param>
        /// <returns></returns>
        public static string TransformToFizzBuzz(int startingPoint, int finishingPoint)
        {
            var fizzBuzzResult = new StringBuilder();

            for (var numberToBeTransformed = startingPoint;
                numberToBeTransformed <= finishingPoint; numberToBeTransformed++)
            {
                var textToPrint = numberToBeTransformed.ToString();

                if (IsDivisibleBy(numberToBeTransformed, FIZZ_BUZZ_NUMBER))
                {
                    textToPrint = FIZZ_BUZZ;
                }
                else if (IsDivisibleBy(numberToBeTransformed, FIZZ_NUMBER))
                {
                    textToPrint = FIZZ;
                }
                else if (IsDivisibleBy(numberToBeTransformed, BUZZ_NUMBER))
                {
                    textToPrint = BUZZ;
                }

                fizzBuzzResult.AppendLine(textToPrint);
            }           

            return fizzBuzzResult.ToString();
        }

        /// <summary>
        /// Returning bool if numerator % denominator becomes zero.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static bool IsDivisibleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }
    }
}
