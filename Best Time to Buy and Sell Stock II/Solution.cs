using System.Linq;
namespace Best_Time_to_Buy_and_Sell_Stock_II {
    public class Solution {
        public int MaxProfit(int[] prices) {
            return RecursiveMaxProfit(prices);
        }

        private int RecursiveMaxProfit(int[] prices, int lastSellDay = 0, int profit = 0, int debugMax = 0) {
            //Exit Condition
            if (debugMax++ > 1000) { return; }
            if (lastSellDay >= prices.Length - 1) { return profit; }
            var result = LargestProfitIndex(prices, lastSellDay);

        }

        private int LargestProfitIndex(int[] prices, int start) {
            bool isFound = false;
            int foundIndex = 0;
            int startPrice = prices[start];
            int highest = 0;
            return prices
                .Where(price => price > startPrice && (price - startPrice) > highest)
                .OrderBy(price => price)
                .Last();

            // for (int i = start + 1; i < prices.Length; i++) {
            //     if (prices[i] > startPrice && (prices[i] - startPrice) > highest) {
            //         isFound = true;
            //         foundIndex = i;
            //         highest = prices[i] - startPrice;
            //     }
            // }
        }
    }
}