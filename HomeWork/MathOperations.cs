using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class MathOperations
    {
        public int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public double squareCulculation(int a, int b)
        {
            if(a > b)
            {
                return Math.Sqrt(a); 
            }
            else
            {
                return Math.Sqrt(b);
            }
        }
    }
}
