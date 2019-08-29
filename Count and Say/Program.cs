using System;

namespace Count_and_Say {
  internal static class Program {
    private static void Main(string[] args) {
      var solve = new Solution();
      var inputs = new int[] {
        1,
        4,
      };

      foreach(var input in inputs) {
        Console.WriteLine(solve.CountAndSay(input));
      }
    }
  }
}