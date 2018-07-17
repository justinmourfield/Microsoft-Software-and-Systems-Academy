using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeofHemi
{
    class HemiTryCatch
    {
        static void Main()

        {
            START:
            try
            {
                
                Console.WriteLine("Enter the value of the radius.");
                double radiusValue = double.Parse(Console.ReadLine());
                if (radiusValue < 0)
                {
                    Console.WriteLine("Please enter positive values only.");
                    goto START;
                }
                VolumeofHemi(radiusValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
                goto START;
            }
        }

        private static void VolumeofHemi(double radiusValue)//method that does the calculations by using the value the user input and was assigned
            //to the variable radiusValue.
        {
            try
            {
                checked
                {
                    double pi = 3.14159;
                    double volume = (4 / 3) * pi * (radiusValue * radiusValue * radiusValue);
                    Console.WriteLine($"The volume of the hemisphere is {volume}.");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value too large to compute.");
            }
            finally
            {
                Console.WriteLine("The program has ended.");
            }

        }
    }
}

