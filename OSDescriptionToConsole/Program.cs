using System;
using System.Runtime.InteropServices;

namespace OSDescriptionToConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"{nameof(RuntimeInformation.FrameworkDescription)}: {RuntimeInformation.FrameworkDescription}");
            Console.WriteLine($"{nameof(RuntimeInformation.OSArchitecture)}: {RuntimeInformation.OSArchitecture}");
            Console.WriteLine($"{nameof(RuntimeInformation.OSDescription)}: {RuntimeInformation.OSDescription}");
            Console.WriteLine($"{nameof(RuntimeInformation.ProcessArchitecture)}: {RuntimeInformation.ProcessArchitecture}");
            Console.WriteLine();
            Console.WriteLine("Press a key to close...");
            Console.ReadKey();
        }
    }
}
