using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreeSum {
  internal class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
      IList<IList<int>> result = new List<IList<int>>();
      List<int> zeroSumList;
      Array.Sort(nums);

      for(int i = 0; i < nums.Length - 2; i++) {
        for(int i2 = i + 1; i2 < nums.Length - 1; i2++) {
          for(int i3 = i2 + 1; i3 < nums.Length; i3++) {
            if((nums[i] + nums[i2] + nums[i3]) == 0) {
              Program.PrintArray<int>(new int[] { nums[i], nums[i2], nums[i3] });
            }
          }
        }
      }

      return result;
    }

    private bool Contains(ref IList<IList<int>> existingLists, ref List<int> newList) {
      bool result = false;

      foreach(IList<int> list in existingLists) {
        if(newList[0] == list[0]
          && newList[1] == list[1]
          && newList[2] == list[2]) {
          result = true;
          break;
        }
      }
      return result;
    }
  }
}
