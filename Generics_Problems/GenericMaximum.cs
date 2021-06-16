using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problems
{

    public class GenericMaximum<T> where T : IComparable
    {
        public T[] array;
        public GenericMaximum(T[] array)
        {
            this.array = array;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        void add(params int[] a)
        {

        }
        public T MaxValue(params T[] values)
        {
            T[] sortedArray = Sort(this.array);

            return sortedArray[sortedArray.Length - 1];
        }
        public void PrintMax()
        {
            T[] sortedArray = Sort(this.array);
            Console.WriteLine(sortedArray[sortedArray.Length - 1]);
        }
    }

}
