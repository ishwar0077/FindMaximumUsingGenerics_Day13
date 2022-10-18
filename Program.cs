using FindMaximumUisngGenerics;

namespace FindMaximumUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Find max.");
            MaximumNumber maximumNumber = new MaximumNumber(); //creating Object
          int max = maximumNumber.MaximumIntegerNumber(21, 22, 19); 
            Console.WriteLine("Maximum Numbr is: {0}",max);

        }
    }

}