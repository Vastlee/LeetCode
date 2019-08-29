using System.Collections.Generic;

namespace Count_and_Say {
  internal class Solution {
    public string CountAndSay(int n) {
      List<int> conv;
      var nums = new List<int>() { 1 };

      int seqCount;
      for(int i = 1; i < n; i++) {
        conv = new List<int>();
        for(int i2 = 0; i2 < nums.Count; i2 += seqCount) {
          seqCount = SequenceCount(ref nums, i2);
          conv.Add(seqCount);
          conv.Add(nums[i2]);
        }
        nums = conv;
      }

      return string.Join(",", nums).Replace(",", string.Empty);
    }

    private int SequenceCount(ref List<int> nums, int startIndex) {
      int result = 1;

      for(int i = startIndex + 1; i < nums.Count; i++) {
        if(nums[i] == nums[startIndex]) {
          result++;
        } else {
          break;
        }
      }
      return result;
    }
  }
}