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
            string[] result = SolveRiddle.Solve(grid);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}