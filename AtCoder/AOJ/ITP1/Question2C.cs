using System.Text;
using AtCoder.Question;
using System;
using System.Linq;
using System.Text;

namespace AtCoder.AOJ.ITP1;

public class Question2C : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        var result = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            int.TryParse(input[i], out var r);
            result[i] = r;
        }

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (result[i] > result[j])
                {
                    (result[i], result[j]) = (result[j], result[i]);
                }
            }
        }

        Console.WriteLine(String.Join(" ", result));
        
    }
    
    
    
}