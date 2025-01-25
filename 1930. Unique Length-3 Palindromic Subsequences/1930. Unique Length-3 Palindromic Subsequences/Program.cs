using System.Text;

public class Program
{
    static void Main()
    {
        var test = new Solution();

        var res = test.CountPalindromicSubsequence("bbcbaba");

        Console.WriteLine(res);
    }
}
public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        var palindroms = new HashSet<string>();
        string prefix = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (!prefix.Contains(s[i]))
            {
                prefix += s[i];
            }
            else
            {
                for (int k = prefix.IndexOf(s[i]); k <= prefix.Length-1; k++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(s[i]);
                    sb.Append(s[k]);
                    sb.Append(s[i]);
                    palindroms.Add(sb.ToString());
                }

                prefix.Remove(prefix.IndexOf(s[i]),2);
                prefix += s[i];
            }
            
        }

        return palindroms.Count;
    }
}