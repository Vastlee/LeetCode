using System;

namespace Implement_strStr {
  internal static class Program {
    private static void Main(string[] args) {
      var solve = new Solution();
      string[][] input = {
        new string[] {
          "hello", "ll"
        },
        new string[] {
          "aaaaa", "bba"
        },
        new string[] {
          "a", "a"
        },
      };

      foreach(string[] i in input) {
        Console.WriteLine(solve.StrStr(i[0], i[1]));
      }
    }
  }
}