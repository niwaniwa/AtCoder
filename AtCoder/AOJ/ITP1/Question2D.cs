using AtCoder.Question;

namespace AtCoder.AOJ.ITP1;

public class Question2D : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var w);
        int.TryParse(input[1], out var h);
        int.TryParse(input[2], out var x);
        int.TryParse(input[3], out var y);
        int.TryParse(input[4], out var r);

        if (x + r <= w && 0 <= x - r)
        {
            if (y + r <= h && 0 <= y - r)
            {
                Console.WriteLine("Yes");
                return;
            }
        }
        
        Console.WriteLine("No");
        
    }
}