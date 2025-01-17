
public class Program
{
    static void Main()
    {
        var test = new Solution();

        var res = test.DoesValidArrayExist(new int[] { 1, 1,0 });
        
        Console.WriteLine(res);
    }
    
}


public class Solution
{
    public bool DoesValidArrayExist(int[] derived)
    {
        int[] original = new int[derived.Length];

        original[0] = 0;

        for (int i = 0; i < derived.Length-1; i++)
        {
            if (original[i] == 0)
            {
                if (derived[i] == 0)
                {
                    original[i + 1] = 0;
                }

                else
                {
                    original[i + 1] = 1;
                }
            }

            else
            {
                if (derived[i] == 1)
                {
                    original[i + 1] = 0;
                }

                else
                {
                    original[i + 1] = 1;
                }
            }
        }

        if ((original[original.Length - 1] ^ original[0]) == derived[derived.Length - 1])
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}