using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTraining.Tests.TrainingsTests
{
    [TestClass]
    public class ExerciceFourTest
    {
        [TestMethod]
        public void GetFrequentNumber()
        {
            var training = new Trainings.ExerciceFour();
            var output = training.MostfrequentNumber(new List<int> { 1, 2, 3, 2, 2, 4, 5, 5 });
            var expected = 2;
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void GetErrorFrequentNumber()
        {
            var training = new Trainings.ExerciceFour();
            var output = training.MostfrequentNumber(new List<int> { 1, 2, 3, 2, 2, 4, 5, 5 });
            var expected = 2;
            Assert.AreNotSame(expected, output);
        }
    }
}
