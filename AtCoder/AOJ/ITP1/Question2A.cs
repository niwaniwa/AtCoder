using AtCoder.Question;

namespace AtCoder.AOJ.ITP1;

public class Question2A : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        // int.TryParse(, out var time);

        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var a);
        int.TryParse(input[1], out var b);

        if (a < b)
        {
            Console.WriteLine("a < b");
        } else if (a > b)
        {
            Console.WriteLine("a > b");
        }
        else
        {
            Console.WriteLine("a == b");
        }

    }
}