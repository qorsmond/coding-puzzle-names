using System;

namespace CodingExercise
{
    class PuzzleApiClient
    {
        // Upload the answer to Agile Bridge's RESTful API
        // The REST endpoint is hosted here:
        // http://ab-coding-puzzle-api.azurewebsites.net/api/puzzle
        //
        // Documentation can be found here:
        // http://ab-coding-puzzle-api.azurewebsites.net/swagger
        public static void Upload(string puzzleAnswer, string email)
        {
            //TODO: remove this code and add your implementation here
            Console.WriteLine("Upload the puzzle answer [{0}] from [{1}]", puzzleAnswer, email);
        }
    }
}