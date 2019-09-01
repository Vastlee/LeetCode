using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Longest_Common_Prefix {
  internal class Solution {
    public string LongestCommonPrefix(string[] strs) {
      if(strs == null || strs.Length < 1) { return string.Empty; }
      var result = new StringBuilder();

      var skip = new HashSet<int>();
      int longest = strs.OrderBy(x => x.Length).First().Length;

      for(int i = 0; i < longest; i++) {
      }

      return result.ToString();
    }
  }
}