using System.Collections.Generic;

namespace Remove_Duplicates_from_Sorted_Array {
    public static class Solution {
        public static int RemoveDuplicates(int[] nums) {
            var set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++) {
                if (!set.Contains(nums[i])) {
                    set.Add(nums[i]);
                }
            }
            return set.Count;
        }
    }
}