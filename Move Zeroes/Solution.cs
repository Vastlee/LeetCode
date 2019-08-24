namespace Move_Zeroes {
  internal class Solution {
    public void MoveZeroes(int[] nums) {
      if(nums.Length < 2) { return; }

      for(int i = 0; i < nums.Length; i++) {
        if(nums[i] == 0) {
          for(int i2 = i + 1; i2 < nums.Length; i2++) {
            if(nums[i2] != 0) {
              nums[i] = nums[i2];
              nums[i2] = 0;
              break;
            }
          }
        }
      }
    }
  }
}