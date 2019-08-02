using System;
using System.Collections.Generic;

namespace Remove_Duplicates_from_Sorted_Array {
    public class Solution {
        public int RemoveDuplicates(int[] nums) {
            var set = new HashSet<int>();
            int lastGoodIndex = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (!set.Contains(nums[i])) {
                    set.Add(nums[i]);
                    nums[lastGoodIndex++] = nums[i];
                }
            }
            return lastGoodIndex;
        }
    }
}
