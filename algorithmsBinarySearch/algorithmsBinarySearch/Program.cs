using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmsBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            string result = binarySearch(primes, 79);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string binarySearch(int[] array, int targetValue)
        {
            int min = 0;
            int max = array.Length - 1;
            int guess;
            int tries = 0;

            while(min <= max)
            {
                tries++;
                guess = (max + min) / 2;
                int valueOfIndex = array[guess];

                if(valueOfIndex == targetValue)
                {
                    return "Index is " + guess + " and number of tries " + tries;
                }
                else if (valueOfIndex < targetValue)
                {
                    min = guess + 1;
                }
                else
                {
                    max = guess - 1;
                }
             }
            return "Not a Prime number";
        }
    }
}
