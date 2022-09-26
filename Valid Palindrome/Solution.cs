using System.Linq;
using System.Text;

namespace Valid_Palindrome {
    internal class Solution {
        private static readonly int LowestNumeric = 48;
        private static readonly int HighestNumeric = 57;
        private static readonly int LowestAlpha = 65;
        private static readonly int HighestAlpha = 90;
        private static readonly int CapitalOffset = 32;

        public bool IsPalindrome(string s) {
            s = s.ToLower();
            char currentChar;
            var forward = new StringBuilder(s.Length);

            for(int i = 0; i < s.Length; i++) {
                currentChar = s[i];
                if(IsAlphaOrDigit(currentChar)) {
                    forward.Append(currentChar);
                }
            }

            for(int i = 0; i < forward.Length/2; i++) {
                if(forward[i] != forward[forward.Length - 1 - i]) { return false; }
            }

            return true;
        }

        private bool IsDigit(char c) {
            return c >= LowestNumeric && c <= HighestNumeric;
        }

        private bool IsAlpha(char c) {
            return (c >= LowestAlpha && c <= HighestAlpha)
                || (c >= LowestAlpha + CapitalOffset && c <= HighestAlpha + CapitalOffset);
        }

        private bool IsAlphaOrDigit(char c) {
            return IsDigit(c) || IsAlpha(c);
        }
    }
}

/*
        public bool IsPalindromeLINQ(string s) {
            s = s.ToLower();
            string forward = new string(s.Where(x => char.IsLetterOrDigit(x)).ToArray());
            string reverse = new string(s.Where(x => char.IsLetterOrDigit(x)).Reverse().ToArray());
            return forward == reverse;
        }

*/