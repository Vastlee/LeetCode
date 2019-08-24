using System;

namespace Single_Number {
  internal static class Program {
    private static void Main(string[] args) {
      Console.WriteLine(new Solution().SingleNumber(new int[] { 4, 1, 2, 1, 2 }));
    }
  }
}