using System;

namespace Coloseum
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            Console.Write("Enter Integer: ");
            input = Console.ReadLine();
            int battleSize = Convert.ToInt32(input);
            Console.WriteLine(battleSize * 2);
            Console.WriteLine("Hello World!");
        }
    }
}
