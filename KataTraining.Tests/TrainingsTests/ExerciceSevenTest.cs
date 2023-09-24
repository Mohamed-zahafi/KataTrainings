using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Tests.TrainingsTests
{
    //### Écrire un programme qui demande à l'utilisateur de saisir deux chaînes de caractères et qui affiche si ces deux chaînes sont des anagrammes.
    //**Exemple**
    //Entrée : "listen", "silent"

    //Sortie : "Les chaînes sont des anagrammes"

    [TestClass]
    public class ExerciceSevenTest
    {

        [TestMethod]
        public void FindAnargams()
        {
            var training = new Trainings.ExerciceSeven();
            var output = training.GetAnargames(new List<string> { "listen", "silent" });
            Assert.AreEqual("Les chaînes sont des anagrammes", output);

        }

    }
}
