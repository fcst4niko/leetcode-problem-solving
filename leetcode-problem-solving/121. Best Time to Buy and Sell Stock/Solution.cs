namespace leetcode_problem_solving._121._Best_Time_to_Buy_and_Sell_Stock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int lowestPrice = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                int currentPrice = prices[i];
                lowestPrice = Math.Min(currentPrice, lowestPrice);
                maxProfit = Math.Max(maxProfit, currentPrice - lowestPrice);
            }

            return maxProfit;
        }
    }

    //public int MaxProfit(int[] prices)
    //   {
    //       int maxProfit = 0;
    //       for (int i = 1; i < prices.Length; i++)
    //       {
    //           for (int j = 0; j < i; j++)
    //           {
    //               int profit = prices[i] - prices[j];

    //               if (profit > maxProfit)
    //               {
    //                   maxProfit = profit;
    //               }
    //           }
    //       }

    //       return maxProfit;
    //   }
}
