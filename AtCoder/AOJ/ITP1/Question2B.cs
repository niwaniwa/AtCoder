using AtCoder.Question;

namespace AtCoder.AOJ.ITP1;

public class Question2B: IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var a);
        int.TryParse(input[1], out var b);
        int.TryParse(input[2], out var c);
        
        Console.WriteLine((0 <= a && a < b && b < c && c <= 100) ? "Yes" : "No");

    }
}