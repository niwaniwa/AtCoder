using System;
using AtCoder.Question;

public class CQuestion : IQuestion
{
    public static string QuestionModifier()
    {
        throw new NotImplementedException();
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ");
        int.TryParse(input[0], out var n);
        int.TryParse(input[1], out var m);

        // sort
        var urite = Console.ReadLine().Split(" ").Select(int.Parse).OrderBy(x => x).ToArray();
        var kaite = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(x => x).ToArray();

        // 解説 https://atcoder.jp/contests/abc312/editorial/6856
        int left = 0, right = (int)1e9 + 1;
        while (right - left > 1)
        {
            int mid = (left + right) / 2;
            // あるxで　f(x)　≥　g(x) となるなら、x　≤　y となる任意のyで　f(y)　≥　f(x)　≥　g(x)　≥g　(y)を満たす
            // 中央の値において買い手より売り手が多い時、単調増加なので、この価格以上はmidより買い手が少ない
            // なので二部探索において、上限をmidにする
            if (Check(mid, urite, kaite))
            {
                right = mid;
            }
            else
            {
                left = mid;
            }
        }

        Console.WriteLine(right);
    }

    private static bool Check(int x, int[] urite, int[] kaite)
    {
        int f = urite.Count(a => a <= x);
        int g = kaite.Count(b => b >= x);
        return f >= g;
        
    }
}