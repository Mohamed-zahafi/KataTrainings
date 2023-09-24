using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Tests.TrainingsTests
{
    [TestClass]
    public class ExerciceFiveTest
    {
        //### Écrire un programme qui demande à l'utilisateur de saisir une liste de mots et qui affiche les mots qui sont des palindromes.
        //** Exemple**
        //Entrée : ["radar", "hello", "level", "madam"]

        //Sortie : "radar", "level", "madam"

        [TestMethod]
        public void TestPalindromeWords()
        {
            var training = new Trainings.ExerciceFive();
            var output = training.GetPalindromWords(new List<string> { "radar", "hello", "level", "madam"});
            CollectionAssert.AreEqual(new List<string> { "radar", "level", "madam" }, output);
        }
    }
}
