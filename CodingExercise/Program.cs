using System;

namespace CodingExercise
{
    class Program
    {
        static void Main()
        {
            // Step 1 - Solve the puzzle
            string puzzleAnswer = PuzzleSolver.Solve(42);

            // Step 2 - Upload answer to Agile Bridge's REST API
            //PuzzleApiClient.Upload(puzzleAnswer, "your email address here");

            Console.WriteLine(puzzleAnswer);


            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}