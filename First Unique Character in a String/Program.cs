using System;

namespace First_Unique_Character_in_a_String {
  internal static class Program {
    private static void Main(string[] args) {
      var input = new string[] {
        "leetcode",
        "loveleetcode",
        "",
      };
      var solve = new Solution();
      foreach(string s in input) {
        Console.WriteLine(solve.FirstUniqChar(s));
      }
    }
  }
}