namespace AtCoder.Question.AtCoderBeginnerContest311;

public class Bquestion : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }


    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var n);
        int.TryParse(input[1], out var d);

        var maxHima = 0;
        var count = 0;
        var arrays = new string[n];

        for (int i = 0; i < n; i++)
        {
            arrays[i] = Console.ReadLine();
        }

        for (int i = 0; i < d; i++)
        {
            var isX = false;
            for (int j = 0; j < n; j++)
            {
                
                if (arrays[j][i] == 'x')
                {
                    isX = true;
                }
                // Console.WriteLine($"{arrays[j][i]}, {isX}");
            }

            count = isX ? 0 : count + 1;

            if (count > maxHima)
            {
                maxHima = count;
            }
        }
        
        Console.WriteLine(maxHima);
        
    }
}