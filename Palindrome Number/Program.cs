using System;

namespace Palindrome_Number {
    class Program {
        static void Main(string[] args) {
            var solve = new Solution();
            int[] testInput = new int[] {
                121,
                -121,
                12345,
                12211221
            };

            for (int i = 0; i < testInput.Length; i++) {
                Console.WriteLine($"Testing [{testInput[i]}] | Result: {solve.IsPalindrome(testInput[i])}");
            }
        }
    }
}