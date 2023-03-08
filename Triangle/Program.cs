using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            string s = args[1];

            for (int i = 1; i <= n; i++)
            {
                for (int t = 1; t <= i; t++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }
        }
    }
}
