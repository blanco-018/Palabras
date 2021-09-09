using System;

namespace Palabras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una palabra o la frase que te venga a la cabeza : ");
            Console.WriteLine(" ");
            string palabrita = Console.ReadLine();

            for (int i = 0; i < palabrita.Length; i++)
            {
                System.Console.Write(palabrita[palabrita.Length - i - 1]);
                Console.WriteLine(" ");

            }
        }
    }
}
