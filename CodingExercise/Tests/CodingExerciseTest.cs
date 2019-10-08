using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingExercise.Tests
{
    [TestClass]
    public class CodingExerciseTest
    {
        [TestMethod]
        public void Test_COLIN_938th()
        {
            // Make sure that COLIN's NameScore would be COLIN49714
            string puzzleAnswer = PuzzleSolver.Solve(938);                       

            Assert.AreEqual(puzzleAnswer, "COLIN49714");
        }

        [TestMethod]
        public void Test_Position_42()
        {
            string puzzleAnswer = PuzzleSolver.Solve(42);

            Assert.AreEqual(puzzleAnswer, "AGATHA1596");
        }
    }
}
