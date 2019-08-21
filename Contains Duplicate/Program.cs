using System;

namespace Contains_Duplicate {
  internal static class Program {
    private static void Main(string[] args) {
      int[] input = { 1, 2, 3, 1 };
      Console.WriteLine(new Solution().ContainsDuplicate(input));
    }
  }
}