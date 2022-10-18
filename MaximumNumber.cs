using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUisngGenerics
{
    public class MaximumNumber
    {
        //Method for Find Maximum Number
        public int MaximumIntegerNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if(firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            else if(secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else if(thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            else
            {
                
                return 0;
            }
        }
    }
}
