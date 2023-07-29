using AtCoder.Question;

namespace AtCoder.AOJ.ITP1;

public class Question3D : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var count = 0;
        var input = Console.ReadLine().Split();
        int.TryParse(input[0], out var a);
        int.TryParse(input[1], out var b);
        int.TryParse(input[2], out var c);

        for (int i = a; i <= b; i++)
        {
            if (c % i == 0)
            {
                count++;
            }
        }
        
        Console.WriteLine($"{count}");
    }
}