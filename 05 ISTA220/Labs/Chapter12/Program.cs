using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane");
            Airplane myAirplane = new Airplane();
            myAirplane.StartEngine("Contact");
            myAirplane.TakeOff(); 
            myAirplane.Drive();
            myAirplane.Land();
            myAirplane.StopEngine("whirr");

            Console.WriteLine("Journey by car");
            Car myCar = new Car();
            myCar.StartEngine("Vroom");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut Phut");

            Console.WriteLine("\nTesting Polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myAirplane;
            v.Drive();
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
