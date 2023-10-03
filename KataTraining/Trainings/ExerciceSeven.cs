using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    public class ExerciceSeven
    {
        public bool IsAnagram(string word1, string word2)
        {
            char[] char1 = word1.ToCharArray();
            char[] char2 = word2.ToCharArray();

            if (word1.Length != word2.Length)
            {
                Console.WriteLine("Les mots saisis ne sont pas des anagrammes");
            }

            Array.Sort(char1);
            Array.Sort(char2);
            return new string(char1) == new string(char2);
        }
    }
}
