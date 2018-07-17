using System;
using Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            int x = 10;
            for (int i = 2; i<=10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConverttoBase(i)}");
            }
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
