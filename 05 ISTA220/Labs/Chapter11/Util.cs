using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Util
    {
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using parameter list");
            if (paramList==null)
            {
                throw new ArgumentException("Util.Sum : null parameter list");
            }
            else if (paramList.Length==0)
            {
                throw new ArgumentException("Util.Sum: emplty parameter list");
            }

            int sum = 0;
            foreach(int element in paramList)
            {
                sum += element; 
            }
            
            return sum;
        }
        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional Parameters.");
            int sum = param1 + param2 + param3 + param4;
            return sum;
        }
    }
}
