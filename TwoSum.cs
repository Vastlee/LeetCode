using VastTools;

namespace LeetCode;

internal static class TwoSum {
        static Solution solve = new();

    public static void RunTests() {
        Console.WriteLine("Input: { 2, 7, 11, 15 }, 9");
        Console.WriteLine("Expected Ouput: { 0,1 }");
        Console.WriteLine($"Output: {solve.TwoSum(new int[] { 2, 7, 11, 15 }, 9).ToDelimitedString()}");
        Console.WriteLine();

        Console.WriteLine("Input: { 3,2,4 }, 6");
        Console.WriteLine("Expected Ouput: { 1,2 }");
        Console.WriteLine($"Output: {solve.TwoSum(new int[] { 3, 2, 4 }, 6).ToDelimitedString()}");
        Console.WriteLine();

        Console.WriteLine("Input: { 3,3 }, 6");
        Console.WriteLine("Expected Ouput: { 0,1 }");
        Console.WriteLine($"Output: {solve.TwoSum(new int[] { 3, 3 }, 6).ToDelimitedString()}");
        Console.WriteLine();
    }

    class Solution {
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> used = new();
            int targetLeft;

            for(int i = 0; i < nums.Length; i++) {
                targetLeft = target - nums[i];
                if(used.ContainsKey(targetLeft) && used[targetLeft] != i) {
                    return new int[] { used[targetLeft], i };
                } else if(used.ContainsKey(nums[i])) {
                    used[nums[i]] = i;
                } else {
                    used.Add(nums[i], i);
                }
            }

            return Array.Empty<int>();
        }
    }
}

