using System.Text;

namespace AtCoder.Question.BeginnerContest075;

public class Minesweeper : IQuestion
{
    public static string QuestionModifier() => typeof(Minesweeper).ToString();

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

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                var isBomb = line[i][j] == '#';
                if (line[i][j] == '#')
                {
                    output[i, j] = "#";
                }
                else
                {
                    var bombCount = 0;
                    // 左上
                    if (i > 0 && j > 0 && line[i - 1][j - 1] == '#') bombCount++;
                    // 上
                    if (i > 0 && line[i - 1][j] == '#') bombCount++;
                    // 右上
                    if (i > 0 && j + 1 < w && line[i - 1][j + 1] == '#') bombCount++;
                    // 左
                    if (j > 0 && line[i][j - 1] == '#') bombCount++;
                    // 右
                    if (j + 1 < w && line[i][j + 1] == '#') bombCount++;
                    // 左下
                    if (i + 1 < h && j > 0 && line[i + 1][j - 1] == '#') bombCount++;
                    // 下
                    if (i + 1 < h && line[i + 1][j] == '#') bombCount++;
                    // 右下
                    if (i + 1 < h && j + 1 < w && line[i + 1][j + 1] == '#') bombCount++;
                    output[i, j] = $"{bombCount}";
                }
            }
            
        }

        for (int i = 0; i < h; i++)
        {
            var builder = new StringBuilder();
            for (int j = 0; j < w; j++)
            {
                builder.Append(output[i, j]);
            }
            Console.WriteLine(builder.ToString());
        }
        
    }
}