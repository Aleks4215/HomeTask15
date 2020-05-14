using System;
using System.Collections.Generic;

namespace HomeWork15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int ReverseNumber(int sourceNumber)
        {
            int reversed = 0;
            while (sourceNumber > 10)
            {
                int number = sourceNumber % 10;
                reversed = reversed * 10 + number;
                sourceNumber /= 10;
            }

            return reversed;
        }

        public int[] UpdateElementToOppositeSign(int[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] < 0)
                {
                    source[i] = -source[i];
                }
                else
                {
                    source[i] /= 1;
                }
            }
            return source;
        }

        public List<int> FindElementGreaterThenPrevious(int[] source)
        {
            List<int> arr = new List<int>();
            for (int i = 1; i < source.Length; i++)
            {
                if (source[i] > source[i - 1])
                {
                    arr.Add(source[i]);
                }
            }
            return arr;
        }


    }
}
