using AtCoder.Question;

namespace AtCoder.AOJ.ITP1;

public class Question4B : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        float.TryParse(input, out var r);

        Console.WriteLine($"{(r * r * Math.PI).ToString("F8")} {(2 * r * Math.PI).ToString("F8")}");
        
    }
    
}