using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Cracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a password");
            string passWord = Console.ReadLine();
            singleThread(passWord);
        }

        private static void singleThread(string passWord)
        {
            Stopwatch watch = new Stopwatch();
            StringBuilder checkedPass = new StringBuilder();
            watch.Start();
            for (int i = 0; i < passWord.Length; i++)
            {
                for (int j = 33; j <= 126; j++)
                {
                    if (j == (int)passWord[i])
                    {
                        checkedPass.Append((char)j);
                        break;
                    }
                }
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
            Console.WriteLine(checkedPass);
        }     
    }
}
