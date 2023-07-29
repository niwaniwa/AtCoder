using System;
using AtCoder.Question;

public class CQuestion : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var n);
        int.TryParse(input[1], out var m);

        var urite = new int[n];
        var kaite = new int[m];

        var urite_input = Console.ReadLine().Split(" ");
        var kaite_input = Console.ReadLine().Split(" ");
        
        for (int i = 0; i < n; i++)
        {
            int.TryParse(urite_input[i], out var o);
            urite[i] = o;
            // urite = sort(urite);
        }
        
        for (int i = 0; i < m; i++)
        {
            int.TryParse(kaite_input[i], out var o);
            kaite[i] = o;
            // kaite = sort(kaite);
        }
        
        // urite = Sort(urite);
        // kaite = Sort(kaite);

        var maxKakaku = 0;
        var maxKaite = 0;
        var kaiteMax = 0;
        
        
        for (int i = 0; i < n; i++)
        {
            var count = 0;
            for (int j = 0; j < m; j++)
            {
                
                if (urite[i] < kaite[j])
                {
                    count++;
                    if (j == m - 1)
                    {
                        if (maxKaite <= count)
                        {
                            maxKaite = count;
                            if (maxKakaku <= urite[i])
                            {
                                maxKakaku = urite[i];
                            }
                        }
                    }
                }

                if (kaiteMax < kaite[j])
                {
                    kaiteMax = kaite[j];
                }
                
            }
        }

        if (maxKakaku == 0)
        {
            maxKakaku = kaiteMax + 1;
        }
    
        Console.WriteLine($"{maxKakaku}");
        
    }

    public static int[] Sort(int[] input)
    {
        var result = input;
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

        return result;
    }
}