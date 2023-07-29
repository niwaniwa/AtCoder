namespace AtCoder.Question.AtCoderBeginnerContest311;

public class Cquestion : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out var time);

        var h = time / 3600;
        var minutes = (time / 60 - h * 60) ;
        var seconds = time - h * 3600 - minutes * 60;
        
        Console.WriteLine($"{h}:{minutes}:{seconds}");
        
    }
}