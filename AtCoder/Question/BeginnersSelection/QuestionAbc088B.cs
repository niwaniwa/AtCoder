namespace AtCoder.Question.BeginnersSelection;

public class QuestionAbc088B : IQuestion
{
    public static string QuestionModifier() => typeof(QuestionAbc088B).ToString();


    public static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out var count);

        var alice = 0;
        var bob = 0;

        var pointsRaw = Console.ReadLine()!.Split(" ");

        var array = pointsRaw.Select(str =>
        {
            int.TryParse(str, out var point);
            return point;
        }).ToList();

        if (array.Count != count)
        {
            Console.WriteLine("Error array is null."); 
            return;
        }

        for (int i = 0; i < count && i < 100; i++)
        {
            var max = array.Max();
            if (i % 2 == 0)
                alice += max;
            else
                bob += max;

            array.Remove(max);
        }
        
        Console.WriteLine(Math.Abs(alice - bob));
        
    }

    
}