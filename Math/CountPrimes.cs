class Solution
{
    public static int CountPrimes(int n)
    {
        int numPrimes = 0;
        for (int i = 2; i < n; i++)
        {
            // Determine if the number is prime and if it is increment the counter.
            if (i <= 3)
            {
                numPrimes++;
                continue;
            }

            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                    isPrime = false;
            }

            if (isPrime)
                numPrimes++;
        }

        return numPrimes;
    }
}
