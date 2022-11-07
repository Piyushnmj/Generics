namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems");

            MaxNumberCheck<int> objint = new MaxNumberCheck<int>(11, 111, 1111);
            Console.WriteLine("\nMax integer number is: " + objint.MaxMethod());

            MaxNumberCheck<float> objfloat = new MaxNumberCheck<float>(1111, 11111, 111111);
            Console.WriteLine("\nMax integer number is: " + objfloat.MaxMethod());

            MaxNumberCheck<string> objstring = new MaxNumberCheck<string>("11", "111", "1111");
            Console.WriteLine("\nMax integer number is: " + objstring.MaxMethod());
        }
    }
}