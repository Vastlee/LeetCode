using VastTools;

namespace Plus_One {
  internal static class Program {
    private static void Main(string[] args) {
      var input = new int[][] {
        new int[] { 8, 9, 9, 9 },
        new int[] { 9 },
      };
      new Solution().PlusOne(input[1]).Log();
    }
  }
}