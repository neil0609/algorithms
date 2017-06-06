using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmsMergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random a = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int b = a.Next(0, 100);
                arr[i] = b;
            }


            mergeSort(arr, 0, arr.Length - 1);

            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        static public void mergeSort(int[] array, int left, int right)
        {
            int mid;
            if(left < right)
            {
                mid = (left + right) / 2;
                mergeSort(array, left, mid);
                mergeSort(array, mid + 1, right);
                merge(array, left, mid + 1, right);
            }
        }

        private static void merge(int[] array, int left, int mid, int right)
        {
            int[] tempArray = new int[array.Length];
            int leftEnd = mid - 1;
            int tempPos = left;
            int numElements = (right - left) + 1;

            while(left <= leftEnd && mid <= right)
            {
                if (array[left] <= array[mid]) {
                    tempArray[tempPos] = array[left];
                    left++;
                } else {
                    tempArray[tempPos] = array[mid];
                    mid++;
                }
                tempPos++;
            }

            while(left <= leftEnd)
            {
                tempArray[tempPos] = array[left];
                tempPos++;
                left++;
            }

            while(mid <= right)
            {
                tempArray[tempPos] = array[mid];
                tempPos++;
                mid++;
            }

            for(int i = 0; i < numElements; i++)
            {
                array[right] = tempArray[right];
                right--;
            }
        }
    }
}
