using System;

namespace LB1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ind = false;
            float frDig;
            float scDig;
            char oper;
            Console.WriteLine();
            Console.WriteLine("Операции:");
            Console.WriteLine("+ : сложение");
            Console.WriteLine("- : вычитание");
            Console.WriteLine("* : умножение");
            Console.WriteLine("/ : деление");
            Console.WriteLine();
            while (!ind)
            {
                ind = true;
                Console.Write("First digit: ");
            first:
                try
                {
                    frDig = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid 1 digit");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Enter 1 digit: ");
                    goto first;
                }

                Console.Write("Enter operation: ");
                oper = char.Parse(Console.ReadLine());
                Console.Write("Enter 2 digit: ");

            second:
                try
                {
                    scDig = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid 2 digit");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Enter 2 digit: ");
                    goto second;
                }

                switch(oper)
                {
                    case '+': Console.WriteLine("Sum is " + (frDig + scDig)); break;
                    case '-': Console.WriteLine("Dif is " + (frDig - scDig)); break;
                    case '*': Console.WriteLine("Com is " + (frDig * scDig)); break;
                    case '/': Console.WriteLine("Quo is " + (frDig / scDig)); break;
                    default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation");
                    }
                    break;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do u want to continue? y");
                string str = Console.ReadLine();
                if (str == "y")
                {
                    ind = false;
                }
                Console.WriteLine();
            }
        }
    }
}
