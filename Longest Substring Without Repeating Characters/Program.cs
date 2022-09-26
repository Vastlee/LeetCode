using System;

namespace Longest_Substring_Without_Repeating_Characters {
    public class Program {
        static void Main(string[] args) {
            Solution solve = new();
            string[] tests = new string[] {
                "abc abcbb",
                "bbbbb",
                "pwwkew",
                " ",
                "au",
                "dvdf"
            };

            foreach(var test in tests) {
                Console.WriteLine($"Test: {test} : {solve.LengthOfLongestSubstring(test.ToString())}");
            }
        }
    }
}
