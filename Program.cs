using FindMaximumUisngGenerics;

namespace FindMaximumUsingGenerics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for Find max");
            Console.WriteLine("--------------------");
            int[] intArray = { 112, 432, 344, 555, 678 };
            GenericsMax<int> generic = new GenericsMax<int>(intArray);
            generic.PrintMaxValue();
            
            Console.WriteLine("--------------------");
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericsMax<double> genericDouble = new GenericsMax<double>(doubleArray);
            genericDouble.PrintMaxValue();

            Console.WriteLine("--------------------");
            string[] strArray1 = { "111", "222", "333", "55", "999" };
            GenericsMax<string> genericString1 = new GenericsMax<string>(strArray1);
            genericString1.PrintMaxValue();
            string[] strArray2 = { "apple", "ball", "cat","dog"};
            GenericsMax<string> genericsString2 = new GenericsMax<string>(strArray2);
            genericsString2.PrintMaxValue();



        }
    }

}