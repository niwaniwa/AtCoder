using AtCoder.Question;

namespace AtCoder.AOJ.ITP1;

public class Question4A : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        int.TryParse(input[0], out var a);
        int.TryParse(input[1], out var b);
        
        // C#の浮動小数点数の精度が原因 8桁まで表示
        Console.WriteLine($"{a / b} {a % b} {((double) a /  b).ToString("F8")}");
        
    }
}