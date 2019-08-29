using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Longest_Common_Prefix {
  internal class Solution {
    public string LongestCommonPrefix(string[] strs) {
      if(strs == null || strs.Length < 1) { return string.Empty; }
      string result = string.Empty;

      foreach(var item in strs.OrderBy(x => x).ToArray()) {
        Console.Write($"{item}, ");
      }

      return result;
    }
  }
}