using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the cylinder's height:");
            string aQ = Console.ReadLine();

            Console.WriteLine("Please enter the cylinder's radius:");
            string rQ = Console.ReadLine();

            int a = Convert.ToInt32(aQ);

            int r = Convert.ToInt32(rQ);

            float pi = 3.1415926f;

            float V = pi * r * r * a;

            Console.WriteLine($"The cylinder's volume is: {V}");
        }
    }
}
