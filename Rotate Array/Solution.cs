namespace Rotate_Array {
  internal class Solution {
    public void Rotate(int[] nums, int k) {
      if(k < 1) { return; }

      int len = nums.Length;
      var tmp = new int[len];

      for(int i = 0; i < len; i++) {
        tmp[(i + k) % len] = nums[i];
      }

      for(int i = 0; i < len; i++) {
        nums[i] = tmp[i];
      }
    }
  }
}

/*  Recursion Solve. Time is too long.
      public void Rotate(int[] nums, int k) {
      if(k < 1 || nums.Length < 2) { return; }

      int first = nums[nums.Length - 1];

      for(int i = nums.Length - 1; i > 0; i--) {
        nums[i] = nums[i - 1];
      }

      nums[0] = first;

      Rotate(nums, --k);
    }
 */