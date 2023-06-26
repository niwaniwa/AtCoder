namespace AtCorder.Question.BeginnersSelection;

public class QuestionAbc088B : IQuestion
{
    public static string QuestionModifier() => typeof(QuestionAbc088B).ToString();


    public static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out var count);

        var alice = 0;
        var bob = 0;

        var pointsRaw = Console.ReadLine().Split(" ");

        var hoge = pointsRaw.Select(str =>
        {
            int.TryParse(str, out var point);
            return point;
        });

        for (int i = 0; i < count && i < 100; i++)
        {

            if (i % 2 == 0)
                alice += hoge.Max();
            else
                bob += hoge.Max();

            hoge = hoge.Where(v => v != hoge.Max());
            
            Console.WriteLine($"{i}:alice {alice}, bob {bob}");
        }
        
        Console.WriteLine(Math.Abs(alice - bob));
        
    }

    
}