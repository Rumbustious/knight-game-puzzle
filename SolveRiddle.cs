using System;
using task.Models;

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
       private static string FindSolution(Pair<int, int> startingPoint, Pair<int, int> currPoint, string[,] input, int count, string ans)
{
    input[currPoint.First, currPoint.Second] = "*";
    count--;

    ans += $"({currPoint.First},{currPoint.Second})";

    if (count == 0)
    {
        int[] dx = { 2, 2, -2, -2, 1, 1, -1, -1 };
        int[] dy = { -1, 1, -1, 1, -2, 2, -2, 2 };

        for (int i = 0; i < 8; i++)
        {
            int newX = currPoint.First + dx[i];
            int newY = currPoint.Second + dy[i];

            if (newX == startingPoint.First && newY == startingPoint.Second)
            {
                ans += $"({startingPoint.First},{startingPoint.Second})";
                input[currPoint.First, currPoint.Second] = "0"; // Backtrack
                return ans;
            }
        }

        input[currPoint.First, currPoint.Second] = "0"; // Backtrack
        return string.Empty;
    }

    int[] dx2 = { 2, 2, -2, -2, 1, 1, -1, -1 };
    int[] dy2 = { -1, 1, -1, 1, -2, 2, -2, 2 };

    for (int i = 0; i < 8; i++)
    {
        int newX = currPoint.First + dx2[i];
        int newY = currPoint.Second + dy2[i];

        if (newX >= 0 && newX < input.GetLength(0) &&
            newY >= 0 && newY < input.GetLength(1) &&
            input[newX, newY] == "0")
        {
            var nextPoint = new Pair<int, int>(newX, newY);
            string result = FindSolution(startingPoint, nextPoint, input, count, ans);
            if (!string.IsNullOrEmpty(result))
            {
                input[currPoint.First, currPoint.Second] = "0"; // Backtrack
                return result;
            }
        }
    }

    input[currPoint.First, currPoint.Second] = "0"; // Backtrack
    return string.Empty;
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
                        var startingPoint = new Pair<int, int>(i, j);
                        string solution = FindSolution(startingPoint, startingPoint, input, count, string.Empty);

                        if (!string.IsNullOrEmpty(solution))
                        {
                            solutions.Add(solution);
                        }
                    }
                }
            }

            return solutions;
        }
    }
}
