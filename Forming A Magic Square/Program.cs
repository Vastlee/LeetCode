using System;

namespace Forming_A_Magic_Square {
  internal static class Program {
    private static void Main(string[] args) {
      Console.WriteLine(new Solution().NumMagicSquaresInside(
        new int[][] {
          new int[] { 1, 8, 6 },
          new int[] { 10, 5, 0 },
          new int[] { 4, 2, 9 }
        }
        ));
    }
  }
}