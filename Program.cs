using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations culculation = new MathOperations();
            Console.WriteLine(culculation.Sum(9, 3));

            Person myPerson = new Person();
            myPerson.GetInitials();

            MathOperations sqrt = new MathOperations();
            Console.WriteLine(Math.Round(sqrt.squareCulculation(25, 12), 2, MidpointRounding.AwayFromZero));

        }
    }
}
