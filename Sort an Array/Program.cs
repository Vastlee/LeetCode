using System;
using System.Collections.Generic;
using System.Drawing;

namespace Sort_an_Array {
    class Program {
        static void Main(string[] args) {
            var problem = new int[] { 5, 5, 2, 3, 1 };
            var output = Solution.SortArray(problem);
            foreach(var item in output) {
                Console.Write($"{item} ");
            }
        }
    }

    class Solution {
        public static int[] SortArray(int[] nums) {
            Array.Sort<int>(nums);
            return nums;
        }
    }
}
