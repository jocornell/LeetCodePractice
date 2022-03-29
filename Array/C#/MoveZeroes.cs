
class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        int i = 0;
        int j = i;
        int temp = 0;

        while (i < nums.Length)
        {

            if (nums[i] == 0)
            {
                j = i + 1;
                while (j < nums.Length)
                {
                    if (nums[j] != 0)
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        break;
                    }
                    j++;
                }
            }

            i++;
        }
    }
}
