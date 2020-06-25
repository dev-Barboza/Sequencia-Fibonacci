using System;

namespace Aula25
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade Sequencia = new Recursividade();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Sequencia Fibonatti");
            Sequencia.GerarSequecia(0,1,20);
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Sequencia Fatorial");
            System.Console.WriteLine(Sequencia.GerarSequeciaFac(7));
        

        }
    }
}
