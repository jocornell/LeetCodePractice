using System;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] prices = { 2, 1, 2, 0, 1 };
            // { 1, 2, 3, 4, 5 };
            // { 5, 4, 3, 2, 1 };
            // { 7, 1, 5, 3, 6, 4};
            var profit = MaxProfit(prices);
        }

        /// <summary>
        /// if stock is increasing wait to sell, if next day stock is less then sell today.
        /// if stock is decreasing wait to buy, if next day stock is more than buy.
        ///
        /// Loop through prices.
        /// keep track of current price
        /// if next day stock is less then sell today.
        /// if next day stock is more than buy.
        ///
        /// profit = price on sell day - price on day of purchase
        /// keep running sum of profit in case you buy and sell multiple times
        ///
        /// need to handle case at end of array
        /// if trying to sell end of array is less
        /// if trying to buy end of array is more
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            int currentPrice = 0;
            int profit = 0;
            int i = 0;

            int purchasePrice = -1;
            int sellPrice = 0;
            bool calculateProfit = false;

            foreach (int price in prices)
            {
                currentPrice = price;

                i++;
                if (!(i >= prices.Length) && prices[i] > currentPrice && purchasePrice < 0)
                {
                    purchasePrice = currentPrice;
                }
                else if ((i >= prices.Length || prices[i] < currentPrice) && purchasePrice >= 0)
                {
                    sellPrice = currentPrice;
                    calculateProfit = true;
                }

                if (calculateProfit)
                {
                    profit += sellPrice - purchasePrice;
                    purchasePrice = -1;
                    sellPrice = 0;
                    calculateProfit = false;
                }
            }

            return profit;

        }


        /* less verbose solution */
        public static int MaxProfit_Shorter(int[] prices)
        {
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }
            return profit;
        }
    }
}
