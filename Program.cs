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
          string max = maximumNumber.MaximumIntegerNumber("apple", "ball", "bigBazzar"); 
            Console.WriteLine("Maximum Numbr is: {0}",max);

        }
    }

}