using System;

namespace Test2
{
    class Program
    {
        // имеем Print(GetSquare(42)); нужно дописать 2 метода Print() и GetSquare(), где 42 должно возводиться еще в квадрат

        static void Main(string[] args)
        {
            Console.Write("Square number is: ");
            Print(GetSquare(42));

            Console.ReadKey();
        }

        static public int GetSquare(int number)
        {
            return (int)Math.Pow(number, 2); // возводим в квадрат число
        }
        static void Print(int number) => Console.WriteLine(number);
    }
}



