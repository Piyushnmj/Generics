using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    internal class Program
    {
        public static void toPrint(int[] inputArray)
        {
            Console.WriteLine("\nint Array: ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void toPrint(double[] inputArray)
        {
            Console.WriteLine("\ndouble Array: ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void toPrint(char[] inputArray)
        {
            Console.WriteLine("\nchar Array: ");
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

            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);

            Console.ReadLine();
        }
    }
}