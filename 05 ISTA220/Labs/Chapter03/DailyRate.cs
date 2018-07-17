using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double dailyRate = readdouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of working days: ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        private void writeFee(double v) => Console.Write($"The Consultant's fee is: {v * 1.1}");


        private double calculateFee(double dailyRate, int noOfDays) => dailyRate * noOfDays;

        private int readInt(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private double readdouble(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return double.Parse(line);
        }
    }
}