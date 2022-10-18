using FindMaximumUisngGenerics;

namespace FindMaximumUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaximumNumber maximumNumber = new MaximumNumber(); //creating Object
          int max = maximumNumber.MaximumIntegerNumber(21, 20, 19); 
            Console.WriteLine("Maximum Numbr is: {0}",max);

        }
    }

}