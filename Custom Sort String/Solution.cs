using System.Collections.Generic;
using System.Text;

namespace Custom_Sort_String {
    public class Solution {
        public string CustomSortString(string order, string input) {
            var charCollection = new Dictionary<char, int>();
            var builder = new StringBuilder();

            BuildCharCollection(ref charCollection, input);
            AppendMatchingChars(ref charCollection, ref builder, order);
            AppendRemainingChars(ref charCollection, ref builder, input);

            return builder.ToString();
        }

        private void BuildCharCollection(ref Dictionary<char, int> charCollection, string input) {
            char currentChar;

            for(int i = 0; i < input.Length; i++) {
                currentChar = input[i];
                if(charCollection.ContainsKey(currentChar)) {
                    charCollection[currentChar]++;
                } else {
                    charCollection.Add(currentChar, 1);
                }
            }
        }

        private void AppendMatchingChars(ref Dictionary<char, int> charCollection, ref StringBuilder builder, string order) {
            char currentChar;

            for(int i = 0; i < order.Length; i++) {
                currentChar = order[i];
                while(charCollection.ContainsKey(currentChar) && charCollection[currentChar] > 0) {
                    charCollection[currentChar]--;
                    builder.Append(currentChar);
                }
            }
        }

        private void AppendRemainingChars(ref Dictionary<char, int> charCollection, ref StringBuilder builder, string input) {
            char currentChar;

            for(int i = 0; i < input.Length; i++) {
                currentChar = input[i];
                if(charCollection[currentChar] > 0) {
                    builder.Append(currentChar);
                    charCollection[currentChar]--;
                }
            }
        }
    }
}
