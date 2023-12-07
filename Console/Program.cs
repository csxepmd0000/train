using FizzBuzzNS;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数字を入力してください:");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(FizzBuzzC.CheckFizzBuzz(i));
        }

        Console.WriteLine("Press enter to quit...");
        Console.ReadLine();
    }
}