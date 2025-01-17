



public class Solution
{
    public int WaysToSplitArray(int[] nums)
    {
        long leftSum = 0;
        long rightSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            rightSum += nums[i];
        }

        int count = 0;
        for (int i = 0;i < nums.Length-1; i++)
        {
            leftSum += nums[i];
            rightSum -= nums[i];
            if (leftSum >= rightSum)
            {
                count++;
            }
        }
        return count;
    }
}