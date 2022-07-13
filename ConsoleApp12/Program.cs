using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое слово: ");
            string message = Console.ReadLine();
            Console.Write("Введите кол-во повторов: ");
            int repeat = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
