class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        /*
            1, 2, 3
            output: 1, 2, 4            

            9, 9            
            output: 1, 0, 0

            1, 9
            output: 2, 0

            1, 9, 9 
            output: 2, 0, 0

            1, 8, 9
            output: 1, 9, 0 


            1. Iterate to the last digit.
            2. Increase the last digit by 1 if the the last digit is [1,8]
               Else if the last digit is 9.. change to zero and increase the previous digit by 1.


            9, 9 --> 1, 0, 0
            output: 1, 0, 0

            special case: create a new array of size input.length + 1 (init to default vals)
            stick a 1 in front            
        */

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] != 9)
            {
                digits[i] = digits[i] + 1;
                return digits;
            }
            else
            {
                // 1, 2, 9 --> 1,3,0
                digits[i] = 0;
            }
        }

        digits = new int[digits.Length + 1];
        digits[0] = 1;

        return digits;

    }
}
