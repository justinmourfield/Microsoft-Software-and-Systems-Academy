using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleAreaTryCatch
{
    class triangleAreaTryCatch
    {
        static void Main()
        {
            Console.WriteLine("Test Project");
            GetValues();
            void GetValues()
            {
                try
                {
                    START:
                    Console.WriteLine("Please enter the length of the side A.");
                    double A = int.Parse(Console.ReadLine());
                    if (A <= 0)
                    {
                        Console.WriteLine("Please enter values greater than or equal to 0.");
                        goto START;
                    }

                    Console.WriteLine("Please enter the length of the side B.");
                    double B = int.Parse(Console.ReadLine());
                    if (B <= 0)
                    {
                        Console.WriteLine("Please enter values greater than or equal to 0.");
                        goto START;
                    }

                    Console.WriteLine("Please enter the length of the side C.");
                    double C = int.Parse(Console.ReadLine());
                    if (C <= 0)
                    {
                        Console.WriteLine("Please enter values greater than or equal to 0.");
                        goto START;
                    }

                    double area = Calculate(A, B, C);

                    Console.WriteLine($"{area}");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter only numbers.");
                    GetValues();

                }
            }
        }
            private static double Calculate(double A, double B, double C)

            {

                double halfCircum = (A + B + C) / 2;

                double area = Math.Sqrt(halfCircum * (halfCircum - A) * (halfCircum - B) * (halfCircum - C));

                return area;
            }
        
    }
}
