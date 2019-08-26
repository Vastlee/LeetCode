using System.Collections.Generic;
using System.Linq;

namespace First_Unique_Character_in_a_String {
  internal class Solution {
    public int FirstUniqChar(string s) {
      var unique = new Dictionary<char, IndexCountPair>();

      for(int i = 0; i < s.Length; i++) {
        if(unique.ContainsKey(s[i])) {
          unique[s[i]].Count++;
        } else {
          unique.Add(s[i], new IndexCountPair(i, 1));
        }
      }

      foreach(var pair in unique.Where(kv => kv.Value.Count == 1)) {
        return pair.Value.Index;
      }

      return -1;
    }

    private class IndexCountPair {
      public IndexCountPair(int index, int count) {
        Index = index;
        Count = count;
      }

      public int Index { get; private set; }
      public int Count { get; set; }
    }
  }
}