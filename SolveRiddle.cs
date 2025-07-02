using System;


namespace MyApp
{
    public static class SolveRiddle
    {
        // precheck:
        private static int CountZeros(string[,] input)
        {
            int count = 0;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] == "0")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        private static string FindSolution(int startingPoint, string[,] input)
        {
            // Implement the logic to find the solution based on the starting point and input grid
            // This is a placeholder for the actual implementation
            return "Solution found";
        }
        public static List<string> Solve(string[,] input)
        {

            List<string> solutions = new List<string>();
            
            int count = CountZeros(input);

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] != "*")
                    {
                        // string startingPoint = input[i, j];
                        int startingPoint = i * input.GetLength(1) + j; // Convert 2D index to 1D index
                        string solution = FindSolution(startingPoint, input);

                        solutions.Add(solution);
                    }
                }
            }

            return solutions;
        }
    }
}
