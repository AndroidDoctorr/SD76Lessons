using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Calculator
    {
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            // Console.WriteLine(sum);
            return sum;
        }
        // overload:
        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public int Subtract(int numOne, int numTwo)
        {
            int difference = numOne - numTwo;
            return difference;
        }

        public double Divide(int numOne, int numTwo)
        {
            // return (double) numOne / numTwo;
            // double numOneDouble = Convert.ToDouble(numOne);
            // double numTwoDouble = Convert.ToDouble(numTwo);
            // double quotient = numOneDouble / numTwoDouble;
            double quotient = 3 / 5;
            return quotient;
        }

        public double Add(string numStringOne, string numStringTwo)
        {
            Console.WriteLine("Add method : " + numStringOne + ", " + numStringTwo);
            // double numOne = Double.Parse(numStringOne);
            int numOne = Convert.ToInt32(numStringOne);
            Console.WriteLine(numOne);
            int numTwo = Convert.ToInt32(numStringTwo);
            Console.WriteLine(numTwo);
            return numOne + numTwo;


            // "Nathan,Bob,Devon,Ashley".Split(',');
        }
    }
}
