namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems");

            MaxNumberCheck objMaxNumber = new MaxNumberCheck();

            int output1 = objMaxNumber.MaxNumber<int>(11, 111, 1111);
            Console.WriteLine("\nMax integer number is: " + output1);

            float output2 = objMaxNumber.MaxNumber<float>(1111, 11111, 111111);
            Console.WriteLine("\nMax float number is: " + output2);

            string output3 = objMaxNumber.MaxNumber<string>("11", "111", "1111");
            Console.WriteLine("\nMax string number is: " + output3);
        }
    }
}