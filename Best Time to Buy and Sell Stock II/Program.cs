using System;

namespace Best_Time_to_Buy_and_Sell_Stock_II {
  internal static class Program {
    private static void Main(string[] args) {
      var solution = new Solution();
      int[] input1 = { 7, 1, 5, 3, 6, 4 };
      Console.WriteLine(solution.MaxProfit(input1));
    }
  }
}