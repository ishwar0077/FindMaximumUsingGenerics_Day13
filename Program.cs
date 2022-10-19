using FindMaximumUisngGenerics;

namespace FindMaximumUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Find max");
            Console.WriteLine("--------------------");
            GenericsMax<int>.MaxValue(25, 22, 21);
            GenericsMax<int>.MaxValue(22, 30, 25);
            GenericsMax<int>.MaxValue(55, 23, 45);

            Console.WriteLine("--------------------");
            GenericsMax<double>.MaxValue(25.9,11.1,22.29);
            GenericsMax<double>.MaxValue(22.8,77.7,33.3);
            GenericsMax<double>.MaxValue(45.5,36.1,89.4);

            Console.WriteLine("--------------------");
            GenericsMax<string>.MaxValue("zink", "Aloe", "ball");
            GenericsMax<string>.MaxValue("apple", "Rathod", "ball");
            GenericsMax<string>.MaxValue("apple", "ball", "bigBazzar");
            Console.WriteLine("--------------------");



        }
    }

}