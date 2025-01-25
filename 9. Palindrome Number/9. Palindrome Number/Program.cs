using System.Globalization;

public class Solution
{
    public bool IsPalindrome(int x)
    {

        string num = x.ToString();

        if (x <= 0) return false;
        
        else
        {
            for (int i = 0; i <(num.Length-1)/2; i++)
            {
                if (num[i] != num[num.Length - i-1])
                {
                    return false;
                }
            }
        }

        return true;

    }
}