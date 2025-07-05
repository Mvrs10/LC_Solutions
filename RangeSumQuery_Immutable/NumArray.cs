namespace RangeSumQuery_Immutable;

internal class NumArray
{
    private int[] culmulativeSums;

    public NumArray(int[] nums)
    {
        culmulativeSums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            culmulativeSums[i] = (i == 0) ? nums[i] : culmulativeSums[i - 1] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        return (left == 0) ? culmulativeSums[right] : culmulativeSums[right] - culmulativeSums[left - 1];
    }
}
