using FizzBuzzNS;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzC.GetOutput(i));
            }

            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
    }
}