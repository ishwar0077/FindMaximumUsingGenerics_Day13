using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumUisngGenerics
{
    public class GenericsMax<T> where T : IComparable
    {
        public T[] value;
        public GenericsMax(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;

        }
        public T TestMaximum(params T[] values)
        {
            var sorted_values = Sort(values);

            return sorted_values[sorted_values.Length - 1];
        }

        public T MaxMethod()
        {
            var max = TestMaximum(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = TestMaximum(this.value);
            Console.WriteLine("Maximum value is " + max);
        }

    }
}
