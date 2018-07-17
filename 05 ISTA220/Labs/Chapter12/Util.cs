using System;

namespace Extensions
{
    static class Util
    {
        public static int ConverttoBase(this int i, int baseToConvert)
        {
            if (baseToConvert<2||baseToConvert>10)
            {
                throw new ArgumentException("Value cannot be converted to base " + baseToConvert.ToString());
            }
            int result = 0;
            int iterations = 0;
            do
            {
                int nextDigit = i % baseToConvert;
                result += nextDigit * (int)Math.Pow(10, iterations);
                iterations++;
            }
            while (i!= 0);

            return result;
        }
    }
}