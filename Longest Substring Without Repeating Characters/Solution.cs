using System.Collections.Generic;
using System.Text;

namespace Longest_Substring_Without_Repeating_Characters {
    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            if(s.Length < 1) { return 0; }

            var charTest = new Dictionary<char, int>();
            var sb = new StringBuilder();
            int longest = 0;
            char currentchar;

            for(int i = 0; i < s.Length; i++) {
                currentchar = s[i];

                if(charTest.ContainsKey(currentchar) is false) {
                    charTest.Add(currentchar, i);
                    sb.Append(currentchar);
                    longest++;
                }
            }

            return longest;
        }
    }
}
