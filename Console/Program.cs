using FizzBuzzNS;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("数字を入力してください:");
        string strNumber = Console.ReadLine();
        if (int.TryParse(strNumber, out int number2))
        {
            for (int i = 1; i <= Convert.ToInt32(strNumber); i++)
            {
                Console.WriteLine(FizzBuzzC.CheckFizzBuzz(i));
            }

            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
        }
        else
        {
            Console.Write("error");
        }
    }
}