using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            subtract();
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
            
            Console.ReadKey();
        }
    
        static void subtract(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float result = firstValue - secondValue;
            Console.WriteLine($"O resultado da subtração é {result}");

            Console.ReadKey();
        }
    }


}
