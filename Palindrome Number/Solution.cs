using System;
namespace Palindrome_Number {
    public class Solution {
        public bool IsPalindrome(int x) {
            if (x < 0) { return false; }
            char[] chars = x.ToString().ToCharArray();
            for (int i = 0; i < chars.Length / 2; i++) {
                if (chars[i] != chars[chars.Length - 1 - i]) { return false; }
            }
            return true;
        }
    }
}
