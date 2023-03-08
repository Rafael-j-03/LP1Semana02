using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            int i1 = short.MaxValue;
            int i2 = short.MinValue;
            int i3 = sbyte.MaxValue;
            int i4 = sbyte.MinValue;
            Console.WriteLine((short) (i1 + 1));
            Console.WriteLine((short) (i2 - 1));
            Console.WriteLine((sbyte) (i3 + 1));
            Console.WriteLine((sbyte) (i4 - 1));

            double i5 = 2 * double.MaxValue;
            float i6 = -2 * float.MaxValue;
            Console.WriteLine(i5);
            Console.WriteLine(i6);
        }
    }
}
