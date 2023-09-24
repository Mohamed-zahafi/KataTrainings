using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    
    public class ExerciceSix
    {
        //### Écrire un programme qui demande à l'utilisateur de saisir une liste de mots
        //et qui affiche les mots qui contiennent uniquement des lettres majuscules.
        //**Exemple**
        //Entrée : ["Hello", "WORLD", "Test", "ALGORITHM"]

        //Sortie : "WORLD", "ALGORITHM"

        public List<string> GetUpperCaseWords(List<string> words)
        {
            List<string> upperCaseWords = new List<string>();
            foreach (string word in words)
            {
                if(IsUpperCase (word))
                {
                    upperCaseWords.Add (word);
                }
            }
            return upperCaseWords;
        }

        private bool IsUpperCase(string word)
        {
            foreach (char letter in word)
            {
                if (!(letter >= 'A' && letter <= 'Z'))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
