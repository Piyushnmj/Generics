namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems");

            int output = MaxNumberCheck.MaxIntegerNumber(11, 111, 1111);
            Console.WriteLine("\nMax integer number is: " + output);
        }
    }
}