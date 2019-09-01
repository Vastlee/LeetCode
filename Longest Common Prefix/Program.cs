using System;

namespace Longest_Common_Prefix {
  internal static class Program {
    private static void Main(string[] args) {
      var solve = new Solution();
      string[][] inputs = {
        new string[] { "flower", "flow", "flight" },
        new string[] { "dog", "racecar", "car" },
      };

      foreach(var input in inputs) {
        Console.WriteLine(solve.LongestCommonPrefix(input));
      }
    }
  }
}