using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }
        static void Sum()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float secondValue = float.Parse(Console.ReadLine());

            float resultado = firstValue + secondValue;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é {resultado}");
        }
    }


}
