using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using KataTraining.Trainings;

namespace KataTraining.Tests.TrainingsTests
{
    [TestClass]
    public class ExerciceEightTest
    {
        [TestMethod]
        public void TestGetPerfectSquare()
        {
            // Arrange
            var training = new ExerciceEight();
            var input = new List<int> { 1, 4, 8, 9, 16, 25 };
            var expected = new List<int> { 1, 4, 9, 16, 25 };

            // Act
            var output = training.GetPerfectSquare(input);

            // Assert
            CollectionAssert.AreEqual(expected, output);
        }
    }
}
