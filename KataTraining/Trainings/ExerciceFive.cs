using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    //### Écrire un programme qui demande à l'utilisateur de saisir une liste de mots et qui affiche les mots qui sont des palindromes.
    //** Exemple**
    //Entrée : ["radar", "hello", "level", "madam"]

    //Sortie : "radar", "level", "madam"
    public class ExerciceFive
    {
        public List<string> GetPalindromWords(List<string> words)
        {
            List<string> palindromWords = new List<string>();

            foreach (string word in words)
            {
                if(IsPalindrome(word))
                {
                    palindromWords.Add(word);
                }
            }
            return palindromWords;
        }
        public static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
