using System;

namespace String_to_Integer__atoi_ {
  internal static class Program {
    private static void Main(string[] args) {
      var solve = new Solution();
      string[] input = {
        "42",
        "   -42",
        "4193 with words",
        "words and 987",
        "-91283472332",
        "991283472332",
        "",
        " ",
        "-",
        "+1"
      };

      foreach(string s in input) {
        Console.WriteLine(solve.MyAtoi(s));
      }
    }
  }
}