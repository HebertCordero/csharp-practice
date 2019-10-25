public class Solution 
{
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            if (dic.ContainsKey(temp))
                return new int[] { i, dic.GetValueOrDefault(temp) };
            if(!dic.ContainsKey(nums[i]))
                dic.Add(nums[i],i);
        }
        throw new ArgumentException("No two sum solution");
    }
}