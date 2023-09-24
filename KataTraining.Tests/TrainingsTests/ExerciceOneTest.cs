namespace KataTraining.Tests.TrainingsTests
{
    [TestClass]
    public class ExerciceOneTests
    {
        [TestMethod]
        //### ### Écrire un programme qui pour
        //un nombre entier et affiche si ce nombre est pair ou impair.
        //**Exemple**
        //Entrée : 7
        //Sortie : "Le nombre est impair"
        public void SouldBe_impair()
        {
            var traning = new Trainings.ExerciceOne();
            var output = traning.IsPairNumber(7);
            Assert.AreEqual("Le nombre est impair", output);
        }
        [TestMethod]
        public void ShouldBe_pair()
        {
            var traning = new Trainings.ExerciceOne();
            var output = traning.IsPairNumber(6);
            Assert.AreEqual("Le nombre est pair", output);
        }
    }
}
