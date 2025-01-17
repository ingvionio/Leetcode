
public class Program
{
    static void Main()
    {
        var test = new Solution();
        string[] words = { "aba", "bcb", "ece", "aa", "e" };
        int[][] queries = { [0, 2], [1, 4], [1, 1] };
        var res = test.VowelStrings(words, queries);

        foreach ( var query in res)
        {
            Console.Write(query);
        }
    }
}


public class Solution
{
    public int[] VowelStrings(string[] words, int[][] queries)
    {
        var prefix = new int[words.Length];
        int count = 0;
        for (int i = 0; i<words.Length; i++)
        {
            if (IsEnglishVowel(words[i][0]) && IsEnglishVowel(words[i][words[i].Length - 1]))
            {
                count++;
            }
            prefix[i] = count;
        }
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            if (queries[i][0] - 1 >= 0)
                result[i] = prefix[queries[i][1]] - prefix[queries[i][0] - 1];
            else result[i] = result[i] = prefix[queries[i][1]];
        }
        return result;
    }

    static bool IsEnglishVowel(char lowerChar)
    {
        // Проверяем, принадлежит ли символ к множеству гласных
        return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
    }
}