using System;

// Getting User Input | C# | Tutorial 8

namespace CSharpExercises_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            Console.Write("Enter your name:  ");
          
            string name = Console.ReadLine();

            Console.Write("Enter your age:  ");

            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " you are " + age + " years old");

            Console.ReadLine();
        }
    }
}
