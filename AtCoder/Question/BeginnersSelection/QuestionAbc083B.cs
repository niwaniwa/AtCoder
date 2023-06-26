using System.Diagnostics;

namespace AtCoder.Question.BeginnersSelection;

public class QuestionAbc083B : IQuestion
{
    public static string QuestionModifier() => typeof(QuestionAbc083B).ToString();
    
    public static void Main(string[] args)
    {
        var strs = Console.ReadLine().Split(" ");

        int.TryParse(strs[0], out var n);
        int.TryParse(strs[1], out var a);
        int.TryParse(strs[2], out var b);
        
        Console.WriteLine(Calc(n, a, b));
    }

    private static int FindSumOfDigits(int i)
    {
        int sum = 0;
        while (i > 0)
        {
            sum += i % 10;
            i /= 10;
        }

        return sum;
    }

    private static string Calc(int n, int a, int b)
    {
        int all = 0;
        for (int i = 1; i <= n && i <= 10E4; i++)
        {
            var sum = FindSumOfDigits(i);
            if (sum >= a && sum <= b)
            {
                all += i;
            };

        }

        return $"{all}";
    }
}