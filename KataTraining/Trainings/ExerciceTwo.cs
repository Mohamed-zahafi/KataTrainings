using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    public class ExerciceTwo
    {
        //Écrire un programme qui demande à l'utilisateur de saisir un nombre entier et qui affiche
        //tous les nombres premiers inférieurs ou égaux à ce nombre.
        //** Exemple**

        //Entrée : 10

        //Sortie : 2, 3, 5, 7
        public List<int> EqualOrLowerPrimeNumber(int number)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
