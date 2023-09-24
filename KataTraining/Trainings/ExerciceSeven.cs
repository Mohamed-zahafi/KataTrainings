using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    public class ExerciceSeven
    {
        //### Écrire un programme qui demande à l'utilisateur de saisir deux chaînes de caractères et qui affiche si ces deux chaînes sont des anagrammes.
        //**Exemple**
        //Entrée : "listen", "silent"

        //Sortie : "Les chaînes sont des anagrammes"

        public List<string> GetAnargames(List<string> words) 
        {
            List<string> anargamWords = new List<string>();
            foreach (string word in words)
            {
                if (IsAnargam(word))
                {
                    anargamWords.Add(word);
                }
            }
            return anargamWords;
        }

        private bool IsAnargam(string word)
        {









            return true;
        }
    }
}
