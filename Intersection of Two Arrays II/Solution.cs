using System.Collections.Generic;

//TODO: Come up with a better solution. This one is too slow.
namespace Intersection_of_Two_Arrays_II {
  internal class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
      int[] shorter = (nums1.Length < nums2.Length) ? nums1 : nums2;
      int[] longer = (nums1.Length < nums2.Length) ? nums2 : nums1;
      var skipIndex = new HashSet<int>();
      var intersections = new List<int>();

      for(int i = 0; i < shorter.Length; i++) {
        for(int i2 = 0; i2 < longer.Length; i2++) {
          if(skipIndex.Contains(i2)) { continue; }
          if(shorter[i] == longer[i2]) {
            skipIndex.Add(i2);
            intersections.Add(shorter[i]);
            break;
          }
        }
      }

      return intersections.ToArray();
    }
  }
}