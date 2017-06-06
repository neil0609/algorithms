using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmsIsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Scrabble";
            string word2 = "Clab bers";
            string result = isAnagram(word1, word2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string isAnagram(string word1, string word2)
        {

            //char[] letters1 = word1.Split(' ').ToString().ToLower().ToCharArray();
            //char[] letters2 = word2.Split(' ').ToString().ToLower().ToCharArray();
            IEnumerable<string> letters1 = word1.ToLower().ToCharArray().Select(c => c.ToString());
            IEnumerable<string> letters2 = word2.ToLower().ToCharArray().Select(c => c.ToString()); 
            Array.Sort(letters1.ToArray());
            Array.Sort(letters2.ToArray());

            for(int i = 0; i < letters1.Count(); i++)
            {
                if (letters1[i] != letters2[i])
                {
                    return "Is Not An Anagram";                  
                }
            }
            return "It Is An Anagram";
        }
    }
}
