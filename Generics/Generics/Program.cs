using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    internal class Program
    {
        public static void toPrint<T>(T[] inputArray)
        {
            Console.WriteLine($"\n{typeof(T)} Array: ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems");

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4, 1.5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<char>(charArray);

            Console.ReadLine();
        }
    }
}