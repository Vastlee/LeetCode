using System;
using VastTools;

namespace Rotate_Image {
  internal static class Program {
    private static void Main(string[] args) {
      int[][][] input = new int[][][] {
        new int[][] {
          new int[] { 1, 2, 3 },
          new int[] { 8, 0, 4 },
          new int[] { 7, 6, 5 }
        },
        new int[][] {
          new int[] { 0, 1, 2, 3, 4 },
          new int[] { 5, 0, 1, 2, 5 },
          new int[] { 4, 7, 0, 3, 6 },
          new int[] { 3, 6, 5, 4, 7 },
          new int[] { 2, 1, 0, 9, 8 },
        },

        new int[][] {
          new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
          new int[] { 5, 0, 1, 2, 3, 4, 5, 6, 7, 0 },
          new int[] { 4, 7, 0, 1, 2, 3, 4, 5, 8, 1 },
          new int[] { 3, 6, 9, 0, 1, 2, 3, 6, 9, 2 },
          new int[] { 2, 5, 8, 1, 0, 1, 4, 7, 0, 3 },
          new int[] { 1, 4, 7, 0, 3, 2, 5, 8, 1, 4 },
          new int[] { 0, 3, 6, 9, 8, 7, 6, 9, 2, 5 },
          new int[] { 9, 2, 5, 4, 3, 2, 1, 0, 3, 6 },
          new int[] { 8, 1, 0, 9, 8, 7, 6, 5, 4, 7 },
          new int[] { 7, 6, 5, 4, 3, 2, 1, 0, 9, 8 }
        }
      };

      foreach(var matrix in input) {
        new Solution().Rotate(matrix);
        matrix.Log();
        Console.WriteLine();
      }
    }
  }
}