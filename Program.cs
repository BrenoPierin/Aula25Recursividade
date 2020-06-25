using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade recu = new Recursividade();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("---------------Fibonacci-----------------");
            recu.GerarSequenciaDeFibonacci(0,1,15);
            System.Console.WriteLine("----------------Fatorial-----------------");
            System.Console.WriteLine(recu.GerarFatorial(5));
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("----------------Tribonacci----------------");
            recu.GerarSequenciaDeTribonacci( 0, 1, 1, 12);
        }
    }
}
