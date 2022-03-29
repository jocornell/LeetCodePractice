using System;
using System.Collections.Generic;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] nums = { 1, 2 };

            // Solution breaks for k > array.Length.
            int[] nums = { 1, 2, 3 };
            int k = 4; // like k = 1.

        }    

        // O(n) space, O(n) memory.
        public static bool ContainsDuplicateDictionarySolution(int[] nums)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if (!dictionary.ContainsKey(num))
                {
                    dictionary.Add(num, 0);
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        // O(nlogn) time.
        public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                    return true;
            }
            return false;
        }
    }
}
