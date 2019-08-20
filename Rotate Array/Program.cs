using System;
using VastTools;

namespace Rotate_Array {
  internal static class Program {
    private static void Main(string[] args) {
      int[] input = { 1, 2, 3, 4, 5, 6, 7 };
      new Solution().Rotate(input, 3);
      input.Log();
    }
  }
}