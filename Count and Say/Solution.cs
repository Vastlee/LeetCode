using System;
using System.Collections.Generic;

namespace Count_and_Say {
  internal class Solution {
    public string CountAndSay(int n) {
      List<int> nums = new List<int>() { 1 };

      for(int i = 0; i < n; i++) {
        for(int i2 = 0; i2 < nums.Count; i++) {
        }
      }

      return string.Empty;
    }

    private (int Count, int EndIndex) SequenceCount(ref List<int> nums, int startIndex) {
      int result = 1;
      int endIndex = startIndex;

      for(int i = startIndex + 1; i < nums.Count; i++) {
        if(nums[i] == nums[startIndex]) {
          result++;
          endIndex = i;
        }
      }
      return (result, endIndex);
    }
  }
}