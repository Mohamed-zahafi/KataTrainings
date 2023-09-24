using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Trainings
{
    public class ExerciceOne
    {
        //### ### Écrire un programme qui pour
        //un nombre entier et affiche si ce nombre est pair ou impair.
        //**Exemple**
        //Entrée : 7
        //Sortie : "Le nombre est impair"
        public string IsPairNumber(int number) 
        {
            string message = "";
            if(number%2 == 0) 
            {
               message = "Le nombre est pair";
            }
            else
            {
               message = "Le nombre est impair";
            }
            return message;
        }
    }
}
