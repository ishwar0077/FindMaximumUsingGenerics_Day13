using FindMaximumUisngGenerics;

namespace FindMaximumUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Find max");
            Console.WriteLine("--------------------");
            MaximumNumber maximumNumber = new MaximumNumber(); //creating Object
          double max = maximumNumber.MaximumIntegerNumber(24.9, 22.1, 23.2); 
            Console.WriteLine("Maximum Numbr is: {0}",max);

        }
    }

}