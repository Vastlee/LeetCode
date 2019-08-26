using System;

namespace Valid_Palindrome {
  internal static class Program {
    private static void Main(string[] args) {
      var solve = new Solution();
      string[] input = new string[] {
        "A man, a plan, a canal: Panama",
        "race a car",
        "0P",
        "",
        "a"
      };

      foreach(string s in input) {
        Console.WriteLine($"{solve.IsPalindrome(s)} : {s}");
      }
    }
  }
}