using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            //Addition
            var sum = a + b;
            Console.WriteLine($"Addition: {sum}");

            //Subtraction
            var diff = a - b;
            Console.WriteLine($"Subtraction: {diff}");

            //Multiplication
            var product = a * b;
            Console.WriteLine($"Multiplication: {product}");

            //Division
            var quotient = a / b;
            var remainder = a% b;
            Console.WriteLine($"Division: {quotient} with the remainder of {remainder}");
            

           
            Console.WriteLine("What is the radius of your radius?");
            var radius = double.Parse(Console.ReadLine());

            var circle = AreaOfCircle(radius);
            Console.WriteLine($"The area of Circle is {circle}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}
