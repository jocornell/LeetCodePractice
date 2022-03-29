class Solution
{
    //public static int[] TwoSum(int[] nums, int target)
    //{
    //    Dictionary<int, int> map = new Dictionary<int, int>();

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (!map.ContainsKey(nums[i]))
    //            map.Add(nums[i], i);
    //    }

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        int complement = target - nums[i];
    //        if (map.ContainsKey(complement) && map.GetValueOrDefault(complement) != i)
    //        {
    //            return new int[] {i, map.GetValueOrDefault(complement) };
    //        }
    //    }

    //    return null;
    //}

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map.GetValueOrDefault(complement), i };
            }
            if (!map.ContainsKey(nums[i]))
                map.Add(nums[i], i);
        }

        return null;
    }
}
