#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        private static int objectCount = 0;

        public Point(int x, int y) // constructor accepting two inputs 
        {
            this.x = x; // this.variable specifies that the variable is the field in this class
                        // and the x on the right assigns the value of this variable to the field 
            this.y = y;
            objectCount++;

        }
        public Point() // default constructor 
        {
            this.x = -1; // assigns the value -1 to the field in this class 
            this.y = -1;
            objectCount++;
        }
        public double DistanceTo(Point other) // method that accepts one parameter of class type named other and returns a double
        {
            int xDiff = this.x - other.x; // the variable xDiff is assigned the value of the result of the calculation that is done by taking 
                                          // the value assigned to the field x and subtracting the value assigned to the object named other 
                                          // but more specifically you are accessing the value stored within the x variable that was initialized when 
                                          // the object was created by passing the two values (1366, 768) into the constructor that handles two arguments.
                                          // this results in the other.x having a different value than this.x because this.x uses the field's value and 
                                          //other.x uses the value assigned to x after passing in values to the constructor in other words youre subtracting
                                          //the values within an object from the fields since there are only two of each and both are the same data type 
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }
        public static int Objectcount() => objectCount;
      
    }
}
