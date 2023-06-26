using System;
using System.Linq;

namespace AtCoder.Question.BeginnersSelection;


// Shift only
// https://atcoder.jp/contests/abs/tasks/abc081_b
public class QuestionAbc081B : IQuestion
{
    public static string QuestionModifier() => typeof(QuestionAbc081B).ToString();

    public static void Main(string[] args)
    {
        if (!int.TryParse(Console.ReadLine(), out var size)) return;

        var input = Console.ReadLine();
        if(string.IsNullOrEmpty(input))
        {
            Console.WriteLine("0");
            return;
        }

        var sourceArray = input.Split(" ");

        if (size != sourceArray.Length)
        {
            Console.WriteLine("0");
            return;
        }

        var array = Calc(sourceArray);
        var count = 0;
        while (true)
        {
            if(array.Length == 0)
            {
                Console.WriteLine(count);
                return;
            }
            
            array = Calc(array);
            count++;
        }
        
    }

    private static string[] Calc(string[] source)
    {
        var array = new string[source.Length];
        for(int i = 0; i < source.Length; i++)
        {
            if (!int.TryParse(source[i], out var j)) return Enumerable.Empty<string>().ToArray();

            if (j % 2 != 0) return Enumerable.Empty<string>().ToArray();

            array[i] = $"{j / 2}";
        }

        return array;
    }
}