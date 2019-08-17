using System;
using System.Linq;

namespace Reverse_Words_in_a_String_III {
  internal static class Solution {
    internal static string ReverseWords(string s) {
      foreach(var r in s.Split(" ").Reverse().Aggregate((x, y) => x + " " + y)) {
        Console.WriteLine(r);
      }
      return "";
    }

    private static void Main(string[] args) => Console.WriteLine(ReverseWords("Hello World!"));
  }
}