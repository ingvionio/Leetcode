using System.Runtime.CompilerServices;

public class Point
{
    public int value;
    public int cost;

    public  Point(int x, int y)
    {
        value = x;
        cost = y;
    }

   
}


public class Solution
{
    public int MinCost(int[][] grid)
    {
        var Points = new Stack<int>();
        int i = 0;
        int j = 0;
        int currentCost = 0;


        while (true)
        {
            switch (grid[i][j])
            {
                case 1:
                    if (j != grid[i].Length-1)
                    {
                        Points.Push(grid[i][j + 1]);
                        j++;
                    }
                    break;
                case 2:
                    if (j != 0)
                    {
                        Points.Push(grid[i][j - 1]);
                        j--;
                    }
                    break;
                case 3:
                    if (i != grid.Length - 1)
                    {
                        Points.Push(grid[i + 1][j]);
                        i++;
                    }
                    break;
                case 4:
                    if (i != 0)
                    {
                        Points.Push(grid[i - 1][j]);
                        i--;
                    }
                    break;
                default

            }


        }

    }
}