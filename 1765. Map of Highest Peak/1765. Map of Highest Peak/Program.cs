public class Point
{
    public Point(int x, int y)
    {
        i = x; j = y;
    }

    public int i;
    public int j;
}




public class Solution
{
    public int[][] HighestPeak(int[][] isWater)
    {
        var queue = new Queue<Point>();
        for (int i = 0; i < isWater.Length; i++)
        {
            for (int j = 0; j < isWater[i].Length; j++)
            {
                if (isWater[i][j] == 0)
                {
                    isWater[i][j] = 1;
                } 
                else
                {
                    isWater[i][j] = 0;
                    queue.Enqueue(new Point(i, j));
                }
            }
        }

        while (queue.Count > 0)
        {

        }

    }
}