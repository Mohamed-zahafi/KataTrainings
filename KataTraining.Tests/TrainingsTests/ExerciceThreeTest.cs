namespace KataTraining.Tests.TrainingsTestsThree
{
    [TestClass]
    public class ExerciceThreeTest
    {
        [TestMethod]
        //### Écrire un programme qui demande à l'utilisateur de saisir une chaîne de caractères et qui affiche
        //la chaîne de caractères inversée.
        //** Exemple**

        //Entrée : "Hello"

        //Sortie : "olleH"

        public void ShouldBeReversed()
        {
            var training = new Trainings.ExerciceThree();
            var output = training.ReversingWord("Hello");
            Assert.AreEqual("olleH", output);
        }

        [TestMethod]
        public void ShouldNotbeEqual()
        {
            var training = new Trainings.ExerciceThree();
            var output = training.ReversingWord("Hello");
            Assert.AreNotEqual("Hello", output);
        }
    }
}
