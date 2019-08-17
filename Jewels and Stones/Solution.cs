using System.Linq;

namespace Jewels_and_Stones {
  internal class Solution {
    public int NumJewelsInStones(string J, string S) => S.Count(c => J.Contains(c));
  }
}