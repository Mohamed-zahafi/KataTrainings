using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    //### Écrire un programme qui demande à l'utilisateur de saisir une liste
    //de nombres entiers et qui affiche les nombres qui sont des carrés parfaits.

    //** Exemple**

    //Entrée : [1, 4, 8, 9, 16, 25]

    //    Sortie : 1, 4, 9, 16, 25
    public class ExerciceEight
    {
        public List<int> GetPerfectSquare(List<int> numbers)
        {
            List<int> perfectSquares = new List<int>();
            foreach (int number in numbers)
            {

                if (IsPerfectSquare(number))
                {
                    perfectSquares.Add(number);
                }
            }
            return perfectSquares;
        }
        private bool IsPerfectSquare(int number)
        {
            int squareRoot = (int)Math.Sqrt(number);
            return squareRoot * squareRoot == number;
        }
    }
}
