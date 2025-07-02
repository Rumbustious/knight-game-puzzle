using System;

namespace MyApp

{

    /*
        0000
        0000
        0000
        *00*

    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] grid = new string[4, 4]
            {
                { "0", "0", "0", "0" },
                { "0", "0", "0", "0" },
                { "0", "0", "0", "0" },
                { "*", "0", "0", "*" }
            };
            List<string> result = SolveRiddle.Solve(grid);
            if (result.Count == 0)
            {
                Console.WriteLine("No solution found.");
                return;
            }
            Console.WriteLine("Solutions Found: " + result.Count);

            Console.WriteLine("Paths:");
            Console.WriteLine("=====================================");

            foreach (var path in result)
            {
                Console.WriteLine(path);
                Console.WriteLine();
            }
        }
    }
}