using System;

namespace Count_and_Say {
  internal static class Program {
    private static void Main(string[] args) {
      var solve = new Solution();
      int[] inputs = new int[] {
        1,
        4,
        10,
        11,
      };

      foreach(int input in inputs) {
        Console.WriteLine(solve.CountAndSay(input));
      }
    }
  }
}