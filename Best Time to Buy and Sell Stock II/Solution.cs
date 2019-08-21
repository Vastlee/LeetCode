using System;

namespace Best_Time_to_Buy_and_Sell_Stock_II {
  internal class Solution {
    public int MaxProfit(int[] prices) {
      int indexOfLargest = FirstMinValueIndex(prices);
      int len = prices.Length - 1;

      if(indexOfLargest == len) { return 0; }

      int maxProfit = 0;
      int largest;
      int lastBuyPrice = prices[indexOfLargest];
      int difference;

      for(int i = indexOfLargest; i < len; i++) {
        largest = 0;

        for(int i2 = i + 1; i2 < prices.Length; i2++) {
          if(prices[i2] <= prices[i]) { continue; }
          difference = prices[i2] - prices[i];
          Console.WriteLine($"{prices[i2]}-{prices[i]}={difference}");

          if(difference > largest) {
            largest = difference;
            indexOfLargest = i2;
          }
        }
        if(largest > 0) {
          maxProfit += largest;
          i = indexOfLargest;
        }
      }
      return maxProfit;
    }

    private int FirstMinValueIndex(int[] a) {
      int lowest = a[0];
      int indexOfLowest = 0;
      for(int i = 1; i < a.Length; i++) {
        if(a[i] < a[indexOfLowest]) {
          indexOfLowest = i;
        }
      }
      return indexOfLowest;
    }
  }
}