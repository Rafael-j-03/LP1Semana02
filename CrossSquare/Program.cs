using System;

namespace CrossSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int i, j;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    // Write borders
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("#");
                    }

                    // Write the middle with cross Xs
                    else if (i == j || j == (n - i + 1))
                    {
                        Console.Write("X");
                    }

                    // Write the empty spaces
                    else
                    {
                        Console.Write(" ");
                    }
                }
                // Next line
                Console.WriteLine();
            }
        }
    }
}