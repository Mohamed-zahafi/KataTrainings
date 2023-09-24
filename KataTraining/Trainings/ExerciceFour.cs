using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    public class ExerciceFour
    {
        //### Écrire un programme qui demande à l'utilisateur de saisir une liste de nombres entiers et qui affiche le nombre le plus fréquent de cette liste.
        //**Exemple**
        //Entrée : [1, 2, 3, 2, 2, 4, 5, 5]

        //Sortie : 2
        public int MostfrequentNumber (List<int> numbers)
        {
            int mostFrequentNumber = 0; 
            int maxCount = 0; 

            foreach (int number in numbers)
            {
                int count = 0; 

                foreach (int otherNumber in numbers)
                {
                    if (number == otherNumber)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentNumber = number;
                }
            }
            return mostFrequentNumber;
        }
    }
}
