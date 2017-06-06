using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmsQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6, -27, 8, 55, -1 };
            quickSort(array, 0, array.Length - 1);
            foreach(int x in array)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }

        public static void swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        public static int partition(int[] array, int p, int r) {
            int q = p;
            for (int j = p; j < r; j++)
            {
                if(array[j] <= array[r])
                {
                    swap(array, j, q);
                    q++;
                }
            }
            swap(array, r, q);
            return q;
        }

        public static void quickSort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int pivotIndex = partition(array, p, r);
                quickSort(array, p, pivotIndex - 1);
                quickSort(array, pivotIndex + 1, r);
            }
        }

    }
}
