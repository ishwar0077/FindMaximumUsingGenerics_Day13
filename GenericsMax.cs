using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUisngGenerics
{
    public class GenericsMax<T> where T : IComparable
    {
         public static void MaxValue(T firstNumber, T secondNumber, T thirdNumber)
         {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                Console.WriteLine("grater value is: {0}",firstNumber);
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                Console.WriteLine("grater value is: {0}",secondNumber);
            }
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                Console.WriteLine("grater value is: {0}",thirdNumber);
            }
           
         }



   
    }
}
