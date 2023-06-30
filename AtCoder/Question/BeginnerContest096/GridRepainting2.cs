namespace AtCoder.Question.BeginnerContest075;

public class GridRepainting2 : IQuestion
{
    public static string QuestionModifier() => typeof(GridRepainting2).ToString();

    private static int[] dx = new int[] { 0, -1, 1, 0 };
    private static int[] dy = new int[] { -1, 0, 0, 1 };

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var h);
        int.TryParse(input[1], out var w);
        var line = new string[h];
        var output = new string[h, w];

        for (int i = 0; i < h; i++)
        {
            line[i] = Console.ReadLine();
        }

    }
}