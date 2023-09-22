namespace FizzBuzz
{
    static class Program
    {
        static void Main()
        {
            try
            {
                var fizzBuzzResult = ProcessFizzBuzz.TransformToFizzBuzz(1, 100);
                Console.WriteLine(fizzBuzzResult);
            }
            catch (Exception ex)
            {
                throw new Exception("FizzBuzz cannot be generated.", ex);               
            }

            Console.WriteLine();
            Console.WriteLine("Any key to exit.");
            Console.ReadKey();
        }
    }

}