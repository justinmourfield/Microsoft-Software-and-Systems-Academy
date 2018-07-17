using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticFormula
{
    class Program
    {
        static void Main()
        {
            START:
            try
            {
                checked
                {
                    Console.WriteLine("Please enter the value of A.");
                    double A = double.Parse(Console.ReadLine());
                    if (A<0)
                    {
                        Console.WriteLine("Enter values larger than zero.");
                        goto START;
                    }
                    Console.WriteLine("Please enter the value of B.");
                    double B = double.Parse(Console.ReadLine());
                    if (B < 0)
                    {
                        Console.WriteLine("Enter values larger than zero.");
                        goto START;
                    }
                    Console.WriteLine("Please enter the value of C.");
                    double C = double.Parse(Console.ReadLine());
                    if (C < 0)
                    {
                        Console.WriteLine("Enter values larger than zero.");
                        goto START;
                    }
                    calculate();
                
                    void calculate()
                    {
                        double positiveForm = (-B + (Math.Sqrt(B * B - 4 * A * C))) / (2 * A);
                        if ((B * B - 4 * A * C) < 0)
                        {
                            Console.WriteLine("A failure occured while processing the formula. " +
                                "Square root functions cannot be performed on a negative number");
                            
                        }
                            Console.WriteLine($"X = {positiveForm}");
                        double negativeForm = (-B - (Math.Sqrt(B * B - 4 * A * C))) / (2 * A);
                        Console.WriteLine($"X = {negativeForm}");
                    }
                }
             }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter only numbers.");
                        goto START;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Computed value is too high to handle.");
                        goto START;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured.");
                    }
                    finally
                    {
                        Console.WriteLine("The program has terminated.");
                    }
        }
    }
}
