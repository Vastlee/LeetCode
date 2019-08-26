using System;
using System.Linq;

namespace Valid_Palindrome {
  internal class Solution {
    public bool IsPalindrome(string s) {
      s = s.ToLower();
      string forward = new string(s.Where(x => char.IsLetterOrDigit(x)).ToArray());
      string reverse = new string(s.Where(x => char.IsLetterOrDigit(x)).Reverse().ToArray());
      return forward == reverse;
    }
  }
}