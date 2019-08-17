using System;

namespace Jewels_and_Stones {
  internal static class Program {
    private static void Main(string[] args) {
      string jewels = "aA";
      string stones = "aAAbbbb";
      Console.WriteLine(new Solution().NumJewelsInStones(jewels, stones));
    }
  }
}