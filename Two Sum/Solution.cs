using System.Collections.Generic;

namespace Two_Sum {

  internal class Solution {

    public int[] TwoSum(int[] nums, int target) {
      var indices = new Dictionary<int, int>();
      int[] result;
      int resultIndex = 0;

      for(int i = 0; i < nums.Length - 1; i++) {
        for(int i2 = i + 1; i2 < nums.Length; i2++) {
          if(nums[i] + nums[i2] == target) {
            if(!(indices.ContainsKey(i) && indices[i] != i2)) {
              indices.Add(i, i2);
            }
          }
        }
      }

      result = new int[indices.Keys.Count * 2];
      foreach(KeyValuePair<int, int> kvp in indices) {
        result[resultIndex++] = kvp.Key;
        result[resultIndex++] = kvp.Value;
      }

      return result;
    }
  }
}