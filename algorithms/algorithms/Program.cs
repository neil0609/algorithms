using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    class Program
    {
        //********** Binary Search Algorithm  *********************//
        public static int doSearch(int[] primes, int targetValue)
        {
            int min = 0;
            int max = primes.Length - 1;
            int guess;

            while (max >= min)
            {
                guess = Convert.ToInt32(Decimal.Floor(((max + min) / 2)));

                int valueofindex = primes[guess];

                if (valueofindex == targetValue)
                {
                    return guess;
                }
                else if (valueofindex < targetValue)

                {
                    min = guess + 1;
                }
                else
                {
                    max = guess - 1;
                }
            }
            return -1;
        }

        //********** Selection Sort Algorithm  *********************//
        public static void swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }

        public static int indexMin(int[] array, int startIndex)
        {
            int minIndex = startIndex;
            int minValue = array[startIndex];

            for (var i = minIndex + 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minIndex = i;
                    minValue = array[i];
                }
            }
            return minIndex;
        }

        public static void selectionSort(int[] array)
        {
            int minIndex;
            for(int j = 0; j < array.Length; j++)
            {
                minIndex = indexMin(array, j);
                swap(array, j, minIndex);
            }

            for (var i = 0; i < array.Length; i++)
            {
                var num = array[i];
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }

        // ******** insertion sort algorithm ************* //
        public static void insert(int[] array, int rightIndex, int value)
        {
            int x;     
            for (x = rightIndex; x >= 0 && array[x] > value; x--)
            {
                array[x + 1] = array[x];
            }
            array[x + 1] = value;
        }

        public static void insertionSort(int[] array)
        {
            int x;
            for(x = 1; x < array.Length; x++)
            {
                insert(array, x - 1, array[x]);
            }
        }


        //********* Recursive algorithm **************//
        public static void factorial(int n)
        {
            var result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }

        //****** Recursive Palindrome ********//
 
        public static string firstCharacter(string str)
        {

            //return str.Substring(1);
            return str[0].ToString();
        }

        public static string lastCharacter(string str)
        {
            return str.Substring(str.Length - 1, 1);
        }

        public static string middleCharacter(string str)
        {

            str = str.Remove(0, 1);
            str = str.Remove(str.Length - 1, 1);
            return str;
        }

        public static bool isPalindrome(string str)
        {
            if (str.Length <= 1) {
                return true;
            }
            if (firstCharacter(str) != lastCharacter(str))
            {
                return false;
            }
            str = middleCharacter(str);
            return isPalindrome(str);
        }

        //********* MERGE SORT ************//
        static public void mergeSort(int[] arr, int left, int right)
        {
            int mid;

            if (left < right)
            {
                mid = (right + left) / 2;
                mergeSort(arr, left, mid);
                mergeSort(arr, (mid + 1), right);
                merge(arr, left, (mid + 1), right);
            }
        }

        static public void merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid]) {
                    temp[tmp_pos] = numbers[left];
                    left++;
                } else {
                    temp[tmp_pos] = numbers[mid];
                    mid++;
                }
                tmp_pos++;
            }

            while (left <= left_end)
            {
                temp[tmp_pos] = numbers[left];
                tmp_pos++;
                left++;
            }

            while (mid <= right)
            {
                temp[tmp_pos] = numbers[mid];
                tmp_pos++;
                mid++;
            }
                
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }





        static void Main(string[] args)
        {
            //int[] arr = new int[] {3,7,14,2,8,9};
            //merge(arr, 0, Convert.ToInt32(Math.Floor((Convert.ToDouble(0) + Convert.ToDouble(arr.Length) / 2))), arr.Length);
            //int[] arr = new int[] { 14, 7, 3, 12, 9, 11, 6, 2, 18, -55, 155 };

            int[] arr = new int[100];
            Random a = new Random();
            for (int i = 0; i < 100; i++)
            {
                int b = a.Next(0, 1000);
                arr[i] = b;
            }


            mergeSort(arr, 0, arr.Length - 1);

            for (int n = 0; n < arr.Length; n++)
            {
                Console.WriteLine(arr[n]);
            }

            Console.ReadLine();



            //string str = "motor";
            //Console.WriteLine(isPalindrome(str));
            //Console.ReadLine();
            //factorial(3);
            //int[] array = new[] { 22, 11, 99, 88, 9, 7, 42 };
            //insertionSort(array);

            //for(int y = 0; y < array.Length; y++)
            //{
            //    Console.WriteLine(array[y]);
            //    Console.ReadLine();
            //}

            //int[] primes = new[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            //Array.Reverse(primes);

            //int index = indexMin(primes, 2);

            //selectionSort(primes);
            //int result = doSearch(primes, 73);

            //swap(primes, 0, 24);

            //for(var i = 0; i < primes.Length; i++)
            //{
            //    var num = primes[i];
            //    Console.WriteLine(num);
            //}
            //Console.ReadLine();

        }
    }
}


//public static void mergeSort(int[] arr, int p, int r)
//{
//    if (p < r)
//    {
//        //int q = Convert.ToInt32(Math.Floor((Convert.ToDouble(p) + Convert.ToDouble(r) / 2)));
//        int q = (p + r) / 2;
//        mergeSort(arr, p, q);
//        mergeSort(arr, q + 1, r);
//        merge(arr, p, q, r);
//    }
//}

//public static void merge(int[] arr, int p, int q, int r)
//{
//    List<int> lowHalf = new List<int>();
//    List<int> highHalf = new List<int>();

//    int k = p;
//    int i;
//    int j;

//    for (i = 0; k < q; i++, k++)
//    {
//        lowHalf.Add(arr[k]);
//    }
//    for (j = 0; k < r; j++, k++)
//    {
//        highHalf.Add(arr[k]);
//    }

//    k = p;
//    i = 0;
//    j = 0;

//    while (i < lowHalf.Count() && j < highHalf.Count())
//    {
//        if (lowHalf[i] < highHalf[j])
//        {
//            arr[k] = lowHalf[i];
//            i++;
//        }
//        else
//        {
//            arr[k] = highHalf[j];
//            j++;
//        }
//        k++;
//    }

//    while (i < lowHalf.Count())
//    {
//        arr[k] = lowHalf[i];
//        i++;
//        k++;
//    }

//    while (j < highHalf.Count())
//    {
//        arr[k] = highHalf[j];
//        j++;
//        k++;
//    }

//    //for(int n = 0; n < arr.Length; n++)
//    //{
//    //    Console.WriteLine(arr[n]);
//    //}

//    //Console.ReadLine();
//}