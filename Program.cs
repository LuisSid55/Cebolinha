using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            String Texto;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Digite seu texto: ");
            Texto = Console.ReadLine();
            Texto = Texto.Replace("R", "L");
            Texto = Texto.Replace("r", "l");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Cebolinha diz:    {Texto}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
