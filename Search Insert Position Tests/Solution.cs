using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position_Tests {
    public class Solution {
        public int SearchInsert(int[] nums, int target) {
            if(nums.Length is 0) { return 0; }

            int result = 0;
            int startIndex = 0;
            int endIndex = nums.Length;
            int currentIndex = endIndex / 2;

            while(true) {
                if(nums[currentIndex] == target) { return currentIndex; }
                if(nums[currentIndex] > target) {
                    startIndex = currentIndex;
                    currentIndex = SetCurrentIndex(startIndex, endIndex);
                }
                if(nums[currentIndex] < target) {
                    endIndex = currentIndex;
                    currentIndex = SetCurrentIndex(startIndex, endIndex);
                }
            }
        }

        private static int SetCurrentIndex(int startIndex, int endIndex) {
            return ((endIndex - startIndex) / 2) + startIndex;
        }
    }
}
