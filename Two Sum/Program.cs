using System;
using Common;

namespace Two_Sum {
  class Program {
    static void Main(string[] args) {
      int[] nums = new int[] { 2, 7, 11, 15 };
      int target = 9;
      new Solution().TwoSum(nums, target).PrintArray<int>();
    }
  }
}
