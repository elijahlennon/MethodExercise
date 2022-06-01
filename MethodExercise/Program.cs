using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Console.WriteLine("What is your name?"); // output

            var name = Console.ReadLine(); // input

            Console.WriteLine("What is your favorite color?"); //output

            var color = Console.ReadLine(); //input

            Console.WriteLine("What is your favorite animal?"); //output

            var animal = Console.ReadLine(); //input

            Console.WriteLine("What is your favorite band?"); //output

            var band = Console.ReadLine(); //input

            Console.WriteLine($"{name} likes to listen to {band}. When {name} visits the zoo the enjoy the {color} {animal} exhibit.");
        }
    }
}
