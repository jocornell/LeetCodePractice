using System;

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

            Rotate(nums, k);
        }    


        public static void Rotate(int[] nums, int k)
        {

            if (nums.Length == 1)
                return;
            else if (nums.Length == 2)
            {
                for (int i = 0; i < k; i++)
                    Swap(nums, 0, 1);
                return;
            }

            if (k > nums.Length)
                k %= nums.Length;

            for (int i = 0, j = nums.Length - 1; i < j; i++, j--)
            {
                Swap(nums, i, j);
            }

            for (int i = 0, j = k - 1; i < j; i++, j--)
            {
                Swap(nums, i, j);
            }

            for (int i = k, j = nums.Length - 1; i < j; i++, j--)
            {
                Swap(nums, i, j);
            }
        }

        public static void Swap(int[] nums, int i, int j) 
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
