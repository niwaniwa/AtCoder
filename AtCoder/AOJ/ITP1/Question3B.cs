using AtCoder.Question;

namespace AtCoder.AOJ.ITP1;

public class Question3B : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        int i = 0;
        while (true)
        {
            var input = Console.ReadLine();
            if (input.Equals("0 0"))
                return;
            var inputs = input.Split();
            int.TryParse(inputs[0], out var x);
            int.TryParse(inputs[1], out var y);
            
            Console.WriteLine(x > y ? $"{y} {x}" : $"{x} {y}");

        }
    }
}