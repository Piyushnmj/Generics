namespace Generics
{
    public class PrintArray<T>
    {
        public T[] inputArray;

        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void toPrint()
        {
            Console.WriteLine($"\n{typeof(T)} Array: ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems");

            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.4, 1.5 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();

            Console.ReadLine();
        }
    }
}