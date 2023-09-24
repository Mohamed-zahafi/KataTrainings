using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    //### Écrire un programme qui demande à l'utilisateur de saisir une chaîne de caractères et qui affiche
    //la chaîne de caractères inversée.
    //** Exemple**

    //Entrée : "Hello"

    //Sortie : "olleH"
    public class ExerciceThree
    {
        public string ReversingWord(string word)
        {
            int length = word.Length;
            char[] reversedChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                reversedChars[i] = word[length - 1 - i];
            }

            string reversedWord = new string(reversedChars);
            return reversedWord;
        }
    }
}
 