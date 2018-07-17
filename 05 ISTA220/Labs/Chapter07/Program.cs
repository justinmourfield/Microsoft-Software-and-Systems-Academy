using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point(); // creates an object named origin
            Point bottomright = new Point(1366, 768); // calls the overloaded constructor that accepts two arguments 
                                                      // and creates another object named bottomright

        double distance = origin.DistanceTo(bottomright); // creates a local variable named distance. distance is assigned the value of the calculation
                                                          // done by specifying the object and accessing the public method named distanceto within that 
                                                          // class's definition that accepts classes as an argument and passes in the object 
                                                          // named bottomright as argument. origin is the default constructor so x,y are -1,-1 and the 
                                                          // method distanceto accepts the values input to the overloaded constructor as one object and 
                                                          // executes its body of code using these arguments. 
            Console.WriteLine($"Distance is : {distance}");
            Console.WriteLine($"object count is {Point.Objectcount()}");
        }

        static void Main(string[] args)
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
