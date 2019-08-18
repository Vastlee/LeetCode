using VastTools;

namespace Two_Sum {
  internal static class Program {
    private static void Main(string[] args) {
      int[] nums = new int[] { 2, 7, 11, 15 };
      int target = 9;
      new Solution().TwoSum(nums, target).Log();
    }
  }
}