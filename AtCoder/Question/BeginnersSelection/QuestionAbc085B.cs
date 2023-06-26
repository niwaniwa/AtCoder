using System;
using System.Linq;

namespace AtCoder.Question.BeginnersSelection;

public class QuestionAbc085B : IQuestion
{
    public static string QuestionModifier() => typeof(QuestionAbc085B).ToString();

    public static void Main(string[] args)
    {
        if (!int.TryParse(Console.ReadLine(), out var size)) return;
        Calc(size);
    }

    private static void Calc(int size)
    {
        
        var array = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out var diameter)) return;
            array[i] = diameter;
        }

        var convertArray = array.Distinct().ToList();
        // Console.WriteLine($"convertArray {string.Join(",", convertArray)}");
        var count = 0;
        var arraySize = convertArray.Count();
        for (int i = 0; i < arraySize; i++)
        {
            var max = convertArray.Max();
            convertArray.Remove(max);
            count++;
        }
        
        Console.WriteLine(count);

    }
}