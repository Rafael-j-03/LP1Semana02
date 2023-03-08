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

            double V = Math.PI * Math.Pow(r, 2) * a;

            Console.WriteLine($"The cylinder's volume is: {V}");

            double Sa = 2 * Math.PI * r * (r + a);

            Console.WriteLine($"The cylinder's surface area is: {Sa}");
        }
    }
}
