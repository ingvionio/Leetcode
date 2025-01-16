public class Program
{
    static void Main()
    {
        int[] nums1 = { 2, 1, 3 };
        int[] nums2 = { 10, 2, 5, 0 };
        var test = new Solution();
        int res = test.XorAllNums(nums1, nums2);
        Console.WriteLine(res);
    }
}



public class Solution
{
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        int xor1 = 0, xor2 = 0;

        int len1 = nums1.Length;
        int len2 = nums2.Length;

        if (len2%2 != 0 )
        {
            foreach (var el in nums1)
            {
                xor1 ^= el;
            }
        }

        if (len1%2 != 0 )
        {
            foreach(var el in nums2)
            {
                xor2 ^= el;
            }
        }

        return xor1 ^ xor2;
    }
}