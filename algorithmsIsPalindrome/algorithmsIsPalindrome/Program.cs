using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmsIsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "racecar";
            string result = isPalindrome(word);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string firstCharacter(string str)
        {
            return str[0].ToString();
        }

        public static string lastCharacter(string str)
        {
            return str[str.Length - 1].ToString();
        }

        public static string middleCharacter(string str)
        {
            str = str.Remove(0, 1);
            str = str.Remove(str.Length - 1, 1);
            return str;
        }

        public static string isPalindrome(string str)
        {
            if(str.Length <= 1)
            {
                return "it is a Palindrome";
            }
            if(firstCharacter(str) != lastCharacter(str))
            {
                return "it is not a Palindrom";
            }
            str = middleCharacter(str);
            return isPalindrome(str);
        }

    }
}
