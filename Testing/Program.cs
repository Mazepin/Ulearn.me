using System;

namespace Testing
{
    class Program
    {

        static void Main(string[] args)
        {
            // округление до целого с выводом на экран имени и зарплаты

            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
            Console.ReadKey();
        }
        private static string GetGreetingMessage(string name, double salary)
        {
            // возвращает "Hello, <name>, your salary is <salary>"
            double _salary = (double)Math.Ceiling(salary);
            Console.WriteLine($"Hello, {name}, your salary is {_salary}");
            return null;
        }
    }
}
