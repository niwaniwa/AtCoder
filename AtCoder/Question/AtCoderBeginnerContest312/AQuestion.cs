namespace AtCoder.Question.AtCoderBeginnerContest312;

public class AQuestion : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    private static string[] array = new string[]
    {
        "ACE",
        "BDF",
        "CEG",
        "DFA",
        "EGB",
        "FAC",
        "GBD",
    };

    public static void Main(string[] args)
    {
        Console.WriteLine(array.Contains(Console.ReadLine()) ? "Yes" : "No");
    }
}