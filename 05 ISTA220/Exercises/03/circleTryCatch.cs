using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleTryCatch
{
    class CircleTryCatch
    {
        private static void Main()
        {
            START://reference point for the program to return back to if the IF user inputs value that is less than 0.
            try
            {
                //User inputs value of radius to be used in the Circle() method to perform calculations. 
                Console.WriteLine("Please enter the radius value.");
                int radiusInput = int.Parse(Console.ReadLine());
                if (radiusInput < 0)
                {
                    Console.WriteLine("Enter a number greater than 0.");
                    Console.WriteLine("");
                    goto START;
                }
                //Circle() method is called to do calculations using the radiusInput from the user as the argument. 
                Circle(radiusInput);                
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers only.");
                goto START;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please try again.");
            }
            
        }


        private static void Circle(double radiusInput)
        {
            try
            {
                checked
                {
                    double pi = 3.14159;
                    double circumferenceValue = radiusInput * pi * 2;
                    double areaValue = (radiusInput * radiusInput) * pi;                    
                    Console.WriteLine($"The circumference is {circumferenceValue}");
                    Console.WriteLine($"The area of the circle is {areaValue}");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The calculated value is too high for this formula.");
            }
            finally
            {
                Console.WriteLine("The program has terminated.");
            }
        }
        
    }
}
                
                
            
                

   