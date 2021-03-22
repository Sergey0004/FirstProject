using System;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent myParent = new Parent();
            Child myChild = new Child();

            var intInCode = myParent.myPublickIntParent;
            var stringInCode = myParent.myString;
            

          //Console.WriteLine(intInCode);
          //Console.WriteLine(stringInCode.ToString());

            Console.WriteLine(myParent.GetColor());
            Console.WriteLine(myParent.Speak());
            Console.WriteLine("------------------");

            Console.WriteLine(myChild.GetColor());
            Console.WriteLine(myChild.Speak());
            Console.WriteLine("----------------");


            Console.WriteLine(((Parent)myChild).GetColor());
            Console.WriteLine(((Parent)myChild).Speak());


            Console.ReadKey();
        }
    }
}
