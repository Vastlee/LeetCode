namespace Best_Time_to_Buy_and_Sell_Stock_II {
  internal class Solution {
    public int MaxProfit(int[] prices) {
      int result = 0;

      for(int i = 1; i < prices.Length; i++) {
        if(prices[i] > prices[i - 1]) {
          result += prices[i] - prices[i - 1];
        }
      }

      return result;
    }
  }
}