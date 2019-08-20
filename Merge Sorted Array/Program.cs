using VastTools;

namespace Merge_Sorted_Array {
  internal static class Program {
    private static void Main(string[] args) {
      int[] inputOne = { 1, 2, 3, 0, 0, 0 };
      int[] inputTwo = { 2, 5, 6 };

      new Solution().Merge(inputOne, 3, inputTwo, 3);
      inputOne.Log();
    }
  }
}