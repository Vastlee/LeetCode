using VastTools;

namespace Rotate_Array {
  internal class Solution {
    public void Rotate(int[] nums, int k) {
      if(k < 1) { return; }

      int swap;

      for(int i = 0; i <= k; i++) {
        swap = nums[0];
        for(int i2 = 1; i2 < nums.Length; i2++) {
          nums[i2 - 1] = nums[i2];
        }
        nums[nums.Length - 1] = swap;
      }
    }
  }
}