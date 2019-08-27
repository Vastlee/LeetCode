using System;

namespace Magic_Squares_In_Grid {
  internal static class Program {
    private static void Main(string[] args) {
      var solve = new Solution();
      int[][][] input = {
        new int[][] {
          new int[] { 4, 3, 8, 4 },
          new int[] { 9, 5, 1, 9 },
          new int[] { 2, 7, 6, 2 }
        }
      };

      foreach(var test in input) {
        Console.WriteLine(solve.NumMagicSquaresInside(test));
      }
    }
  }
}