using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            short optionSelected = 0;

            while (optionSelected != 5)
            {
                optionSelected = SelectOption();
                if (optionSelected > 0 && optionSelected < 6)
                {
                    ExecuteOperation(optionSelected);
                    Console.ReadKey();
                }
            }
        }

        static void ExecuteOperation(short optionSelected)
        {

            Console.Clear();

            Console.WriteLine("First value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (optionSelected)
            {
                case 1: Sum(firstValue, secondValue); break;
                case 2: Subtract(firstValue, secondValue); break;
                case 3: Divide(firstValue, secondValue); break;
                case 4: Multiply(firstValue, secondValue); break;
                case 5: System.Environment.Exit(0); break;
                default: break;
            }
        }

        static short SelectOption()
        {
            Console.Clear();

            Console.WriteLine("What do you want do?");
            Console.WriteLine("1 - Sum (+)");
            Console.WriteLine("2 - Subtraction (-)");
            Console.WriteLine("3 - Division (/)");
            Console.WriteLine("4 - Multiplication (*)");
            Console.WriteLine("5 - Exit");

            Console.WriteLine("---------");

            Console.WriteLine("Select an option:");
            short optionSelected = short.Parse(Console.ReadLine());

            return optionSelected;
        }

        static void Sum(float a, float b)
        {
            float result = a + b;
            Console.WriteLine($"The result of sum is {result}");
        }

        static void Subtract(float a, float b)
        {
            float result = a - b;
            Console.WriteLine($"The result of subtraction is {result}");
        }

        static void Divide(float a, float b)
        {
            float result = a / b;
            Console.WriteLine($"The result of the division is {result}");
        }

        static void Multiply(float a, float b)
        {
            float result = a * b;
            Console.WriteLine($"The result of multiplication is {result}");
        }

    }


}
