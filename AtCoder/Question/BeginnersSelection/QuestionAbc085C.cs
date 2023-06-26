using System;
using System.Linq;
using AtCoder.Question;

namespace AtCoder.Question.BeginnersSelection;

public class QuestionAbc085C : IQuestion
{
    public static string QuestionModifier() => typeof(QuestionAbc085C).ToString();


    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        
        var n = input[0];
        var y = input[1];
        
        Calc(n, y);
        
    }

    private static void Calc(int n, int y)
    {

        // for (int m = 0; m <= y / 10000 && m < n; m++)
        // {
        //     for (int g = 0; g <= (y - m * 10000) / 5000 && g < n; g++)
        //     {
        //         for (int s = 0; s <= (y - m * 10000 - g * 5000) / 1000 && s < n; s++)
        //         {
        //             if(m+g+s != n)
        //                 continue;
        //             
        //             if(m * 10000 + g * 5000 + s * 1000 == y)
        //             {
        //                 Console.WriteLine($"{m} {g} {s}");
        //                 return;
        //             }
        //             
        //         }
        //     }
        // }
        
        
        for (int m = 0; m <= n; ++m)
        {
            for (int g = 0; m + g <= n; ++g)
            {
                var s = n - g - m;

                if(m * 10000 + g * 5000 + s * 1000 == y)
                {
                    Console.WriteLine($"{m} {g} {s}");
                    return;
                }

            }

        }
        
        Console.WriteLine("-1 -1 -1");

    }
}