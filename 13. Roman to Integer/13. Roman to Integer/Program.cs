using System.Transactions;

public class Solution
{
    public int RomanToInt(string s)
    {
        int sum = 0;
        int previous = 200000;
        for (int i = 0; i < s.Length; i++)
        {
            int current = 0;

            switch (s[i])
            {
                case 'I':current = 1; break;
                case 'V':current = 5; break;
                case 'X': current = 10; break;
                case 'L':current = 50; break;
                case 'C':current = 100; break;
                case 'D':current = 500;break;
                case 'M':current = 1000; break;
            }
            if (current > previous)
            {
                sum -= previous;
                sum += current - previous;
            }
            else
            {
                sum += current;
            }
            previous = current;

        }
        return sum;
    }
}