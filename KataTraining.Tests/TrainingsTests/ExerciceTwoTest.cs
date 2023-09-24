namespace KataTraining.Tests.TrainingsTests
{
    [TestClass]
    public class ExerciceTwoTest
    {
        [TestMethod]
        //Écrire un programme qui demande à l'utilisateur de saisir un nombre entier et qui affiche tous les nombres premiers inférieurs ou égaux à ce nombre.
        //** Exemple**

        //Entrée : 10

        //Sortie : 2, 3, 5, 7
        public void GetTop10PrimeNumbers()
        {
            var training = new Trainings.ExerciceTwo();
            var output = training.EqualOrLowerPrimeNumber(10);
            Assert.AreEqual(string.Join(",", new List<int>() { 2, 3, 5, 7 }), string.Join(",", output));
        }
        [TestMethod]
        public void GetTop100PrimeNumbers()
        {
            var training = new Trainings.ExerciceTwo();
            var output = training.EqualOrLowerPrimeNumber(100);
            Assert.AreEqual(string.Join(",", new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 }), string.Join(",", output));
        }
    }
}
