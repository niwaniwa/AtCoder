using System;
using System.Linq;

namespace AtCorder.Question.BeginnersSelection;


// https://atcoder.jp/contests/abs/tasks/abc087_b
public class QuestionAbs087B : IQuestion
{
    public static string QuestionModifier() => typeof(QuestionAbs087B).ToString();

    public static void Main(string[] args)
    {
        if(!int.TryParse(Console.ReadLine(), out var a)) return;
        if(!int.TryParse(Console.ReadLine(), out var b)) return;
        if(!int.TryParse(Console.ReadLine(), out var c)) return;
        if(!int.TryParse(Console.ReadLine(), out var x)) return;
        
        Console.WriteLine(Calc(a, b, c, x));
        
    }

    private static int Calc(int aMax, int bMax, int cMax, int x)
    {
        int count = 0;
        for (int a = 0; a <= aMax; a++)
        {
            for (int b = 0; b <= bMax; b++)
            {
                for (int c = 0; c <= cMax; c++)
                {
                    var sum = a * 500 + b * 100 + c * 50;
                    if (sum == x)
                        count++;
                }
            }
        }

        return count;
    }
    
}