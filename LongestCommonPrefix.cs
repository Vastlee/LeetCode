using System.Text;

namespace LeetCode;

internal sealed class LongestCommonPrefix {
    static Solution solve = new();

    class Solution {
        public string LongestCommonPrefix(string[] strs) {
            StringBuilder result = new();
            var skip = new HashSet<int>();
            int longest = strs.OrderBy(x => x.Length).First().Length;
            int hits = -1;
            Dictionary<char, List<int>> charHits;

            for(int c = 0; c < longest || hits == 0; c++) {
                hits = 0;
                charHits = new Dictionary<char, List<int>>();

                for(int i = 0; i < strs.Length; i++) {
                    if(skip.Contains(i)) { continue; }
                    if(i >= strs[i].Length && !skip.Contains(i)) {
                        skip.Add(i);
                        continue;
                    }

                    if(charHits.ContainsKey(strs[i][c])) {
                        charHits[strs[i][c]].Add(i);
                    } else {
                        charHits.Add(strs[i][c], new List<int>() { i });
                    }
                }

                var matchLines = charHits
                  .Where(x => x.Value.Count == 1)
                  .Select(x => x.Value)
                  .SelectMany(x => x);

                hits = matchLines.Count();
                if(hits < 2) {
                }

                foreach(int line in matchLines) {
                    skip.Add(line);
                }
            }

            return result.ToString();
        }

    }
}
