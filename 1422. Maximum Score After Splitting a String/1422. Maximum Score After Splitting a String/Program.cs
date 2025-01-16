using System.Linq;

public class Program
{
    static void Main()
    {
        var test = new Solution();
        int res = test.MaxScore("00");
        Console.WriteLine(res);
    }
}

public class Solution
{
    public int MaxScore(string s)
    {
        int lenS = s.Length;
        int max = 0;
        for (int i = 1; i < lenS; i++)
        {
            string s1 = s.Substring(0, i);
            string s2 = s.Substring(i);
            int sum = s1.Count(c => c == '0') + s2.Count(c => c == '1');
            max = Math.Max(max, sum);
        }

        return max;
    }
}