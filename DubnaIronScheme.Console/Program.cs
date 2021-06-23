using DubnaIronScheme.MainModule.Services;
using System;

namespace DubnaIronScheme.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Консольное приложение для быстрой проверки функциональности модулей из пространства имён DubnaIronScheme.MainModule.

            CompilerService schemeCompiler = new CompilerService();

            System.Console.WriteLine("Напишите код программы:");
            string script = System.Console.ReadLine();

            System.Console.WriteLine(schemeCompiler.Run(script));
        }
    }
}
