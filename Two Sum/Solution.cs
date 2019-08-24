using System.Collections.Generic;

namespace Two_Sum {
  public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      var used = new Dictionary<int, int>();

      for(int i = 0; i < nums.Length; i++) {
        var targetLeft = target - nums[i];
        if(used.ContainsKey(targetLeft) && used[targetLeft] != i) {
          return new int[] { used[targetLeft], i };
        } else if(used.ContainsKey(nums[i])) {
          used[nums[i]] = i;
        } else {
          used.Add(nums[i], i);
        }
      }

      return new int[] { };
    }
  }
}