using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                CalculatorMain();
        }

        static void CalculatorMain(){
            Console.Clear();

            Console.WriteLine("What do you want do?");
            Console.WriteLine("1 - Sum (+)");
            Console.WriteLine("2 - Subtraction (-)");
            Console.WriteLine("3 - Division (/)");
            Console.WriteLine("4 - Multiplication (*)");

            Console.WriteLine("---------");

            Console.WriteLine("Select an option:");
            short optionSelected = short.Parse(Console.ReadLine());
            

        }
        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());

            float resultado = firstValue + secondValue;

            Console.WriteLine();
            Console.WriteLine($"The result of sum is {resultado}");
            
            Console.ReadKey();
        }
    
        static void Subtract(){
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float result = firstValue - secondValue;
            Console.WriteLine($"The result of subtraction is {result}");

            Console.ReadKey();
        }

        static void Divide(){
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float result = firstValue / secondValue;

            Console.WriteLine($"The result of the division is {result}");

            Console.ReadKey();
        }

        static void Multiply(){
            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float result = firstValue * secondValue;

            Console.WriteLine($"The result of multiplication is {result}");

            Console.ReadKey();
        }

    }


}
