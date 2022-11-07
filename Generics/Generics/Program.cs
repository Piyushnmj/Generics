namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems");

            int output = MaxNumberCheck.MaxIntegerNumber(11, 111, 1111);
            Console.WriteLine("\nMax integer number is: " + output);

            double output2 = MaxNumberCheck.MaxFloatNumber(11.11, 111.111, 1111.1111);
            Console.WriteLine("\nMax float number is: " + output2);

            string output3 = MaxNumberCheck.MaxStringNumber("11.11", "111.11", "1111.11");
            Console.WriteLine("\nMax string number is: " + output3);
        }
    }
}