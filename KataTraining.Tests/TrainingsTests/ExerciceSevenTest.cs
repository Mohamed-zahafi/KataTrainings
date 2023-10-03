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
        public void AnargamTestOne()
        {
            var training = new Trainings.ExerciceSeven();
            var output = training.IsAnagram("spote", "poste");
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void AnagramTEstTwo()
        {
            var training = new Trainings.ExerciceSeven();
            var output = training.IsAnagram("sport", "poste");
            Assert.AreNotEqual(true, output);
        }
    }
}
