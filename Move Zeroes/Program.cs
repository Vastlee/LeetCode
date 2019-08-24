using VastTools;

namespace Move_Zeroes {
  internal static class Program {
    private static void Main(string[] args) {
      int[][] input = new int[][] {
        new int[] { 0, 1, 0, 3, 12 },
      };

      new Solution().MoveZeroes(input[0]);
      input[0].Log();
    }
  }
}