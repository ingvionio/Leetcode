public class Program
{
    static void Main()
    {
        var test = new Solution();

        int[][] arr = { [20, 3, 20, 17, 2, 12, 15, 17, 4, 15], [20, 10, 13, 14, 15, 5, 2, 3, 14, 3] };

        var res = test.GridGame(arr);
        Console.WriteLine(res);
    }
}


public class Solution
{
    public long GridGame(int[][] grid)
    {
        long firstSum = 0;

        for (int i = 0; i <= grid[0].Length-1; i++) 
        {
            firstSum += grid[0][i];
        }

        firstSum += grid[1][grid[0].Length - 1];
        firstSum -= grid[0][0];

        long remainFirst = firstSum - grid[1][grid[0].Length - 1];

        long currentSecond = 0;
        int n = 0;

        while (true)
        {
            n++;

            currentSecond += grid[1][n-1];
            if (currentSecond > remainFirst)
            {
                currentSecond -= grid[1][n - 1];
                break;
            }

            firstSum -= grid[0][n];
            remainFirst -= grid[0][n];
        }




        return Math.Max(remainFirst, currentSecond);

    }
}