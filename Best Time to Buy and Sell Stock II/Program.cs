using System;

namespace Best_Time_to_Buy_and_Sell_Stock_II {
    class Program {
        static void Main(string[] args) {
            var solve = new Solution();
            var input = new int[] { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine($"{solve.MaxProfit(input)}");
        }
    }
}