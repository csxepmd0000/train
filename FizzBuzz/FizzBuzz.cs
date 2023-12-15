namespace FizzBuzzNS;

public static class FizzBuzzC
{
    public static string CheckFizzBuzz(int number)
    {
        string output;

        if (number > 100)
        {
            output = number.ToString("error");
            return output;
        }

        if ((number % 3 == 0) && (number % 5 == 0))
        {
            output = "FizzBuzz";
        }
        else if (number % 3 == 0)
        {
            output = "Fizz";
        }
        else if (number % 5 == 0)
        {
            output = "Buzz";
        }
        else
        {
            output = number.ToString();
        }


        return output;
    }
}