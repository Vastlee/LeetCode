using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Number {
  internal class Solution {
    public int SingleNumber(int[] nums) {
      var count = new Dictionary<int, int>();
      for(int i = 0; i < nums.Length; i++) {
        if(count.ContainsKey(nums[i])) {
          count[nums[i]]++;
        } else {
          count.Add(nums[i], 1);
        }
      }

      foreach(KeyValuePair<int, int> e in count) {
        if(e.Value == 1) { return e.Key; }
      }

      return -1;
    }
  }
}