using System.Collections;

namespace AtCoder.Question.AtCoderBeginnerContest312;

public class BQuestion : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    private static string[] pattern = new string[]
    {
        "###.?????",
        "###.?????",
        "###.?????",
        "....?????",
        "?????????",
        "?????....",
        "?????.###",
        "?????.###",
        "?????.###",
    };

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var n);
        int.TryParse(input[1], out var m);

        var array = new string[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }

        var result = new List<string>();
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (Check(array, i, j))
                {
                    result.Add($"{i + 1} {j + 1}");
                }
            }
        }
        
        result.ForEach(Console.WriteLine);
        
    }

    public static bool Check(string[] input, int i, int j)
    {
        var isPattern = false;
        var w = 0;
        var h = 0;
        for (int k = 0; k < 9; k++)
        {
            for (int l = 0; l < 9; l++)
            {
                if (i + k >= input.Length || j + l >= input[0].Length)
                    return false;
                
                if (input[i + k][j + l] == pattern[k][l] || pattern[k][l] == '?')
                {
                    
                    w = k;
                    h = l;

                    if (w == 8 && h == 8)
                    {
                        return true;
                    }
                    continue;
                }

                return false;
            }
        }

        return false;
    }
}