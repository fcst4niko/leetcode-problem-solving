using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._122._Best_Time_to_Buy_and_Sell_Stock_II
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int sumProfit = 0;
            int lowestPrice = int.MaxValue;
            int lastProfit = 0;
            int currentPrice = 0;
            int currentProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                currentPrice = prices[i];
                lowestPrice = Math.Min(currentPrice, lowestPrice);
                currentProfit = currentPrice - lowestPrice;


                if (lastProfit > currentProfit)
                {
                    sumProfit += lastProfit;
                    lowestPrice = currentPrice;
                    lastProfit = 0;
                    continue;
                }                
                
                lastProfit = currentProfit;


                //lowestPrice = Math.Min(currentPrice, lowestPrice);
                //maxProfit = Math.Max(maxProfit, currentPrice - lowestPrice);
            }

            if (lastProfit > 0) sumProfit += lastProfit;

            return sumProfit;

        }
    }
}
