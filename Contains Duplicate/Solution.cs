using System.Collections.Generic;

namespace Contains_Duplicate {
  internal class Solution {
    public bool ContainsDuplicate(int[] nums) {
      if(nums.Length < 2) { return false; }
      var found = new HashSet<int>();
      for(int i = 0; i < nums.Length; i++) {
        if(found.Contains(nums[i])) { return true; } else { found.Add(nums[i]); }
      }
      return false;
    }
  }
}