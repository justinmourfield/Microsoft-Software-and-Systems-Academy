#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            /*
            Month first = Month.January;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            */
          //  Date defaultDate = new Date();
           // Console.WriteLine(defaultDate);
            Date weddinganniversary = new Date(2015, Month.October, 10);
            Console.WriteLine(weddinganniversary);
            Date weddinganniversarycopy = weddinganniversary;
            Console.WriteLine(weddinganniversarycopy);
            weddinganniversary.AdvanceMonth();
            Console.WriteLine(weddinganniversary);
            Console.WriteLine($"The value is still {weddinganniversarycopy}.");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
