using System;

namespace olaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario; 
            Console.Write("Digite seu nome: ");
            nomeUsuario = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Olá "+nomeUsuario+"!");
        }
    }
}
