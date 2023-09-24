using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Tests.TrainingsTests
{
    [TestClass]
    public class ExerciceSixTest
    {
        //### Écrire un programme qui demande à l'utilisateur de saisir une liste de mots et qui affiche les mots qui contiennent uniquement des lettres majuscules.
        //**Exemple**
        //Entrée : ["Hello", "WORLD", "Test", "ALGORITHM"]

        //Sortie : "WORLD", "ALGORITHM"

        [TestMethod]
        public void GetUpperWordsTest()
        {
            var training = new Trainings.ExerciceSix();
            var output = training.GetUpperCaseWords(new List<string>{ "Hello", "WORLD", "Test", "ALGORITHM" });
            CollectionAssert.AreEqual(new List<string> { "WORLD", "ALGORITHM" }, output);
        }
    }
}
