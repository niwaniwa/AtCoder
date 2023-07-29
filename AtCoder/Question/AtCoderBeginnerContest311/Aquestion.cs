namespace AtCoder.Question.AtCoderBeginnerContest311;

public class Aquestion : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out var length);
        var str = Console.ReadLine();

        var check = new bool[3];

        for (int i = 0; i < length; i++)
        {
            switch (str[i])
            {
                case 'A':
                    check[0] = true;
                    break;
                case 'B':
                    check[1] = true;
                    break;
                case 'C':
                    check[2] = true;
                    break;
            }

            if (check[0] && check[1] && check[2])
            {
                Console.WriteLine(i+1);
                return;
            }
        }
       
    }
}