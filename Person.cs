using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Person
    {
        public string name = "Serhii";
        public string lastName = "Vrublevskyi";
        public int age = 25;

        public void GetInitials()
        {
            Console.WriteLine($"I'm {age} yers old my name is {name} {lastName}");
        }

        public Person() { }
        public Person(string theName, string TheLastName, int theAge)
        {
            {
                theName = name;
                TheLastName = lastName;
                theAge = age;
            }
        }
    }
}
