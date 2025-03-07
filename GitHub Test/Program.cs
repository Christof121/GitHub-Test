using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Commit 2");
            Console.WriteLine();
            Console.Write("Geben Sie etwas ein: ");
            string ui = Console.ReadLine();

            Console.WriteLine($"Ihre Eingabe: {ui}");

            Console.WriteLine("\nDas Programm ist zuende, drücken Sie eine belibige Taste um es zu beenden.");
            Console.ReadLine();
        }
    }
}
