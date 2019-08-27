namespace Reverse_Words_in_a_String_III {
  internal class Solution {
    internal string ReverseWords(string s) {
      char[] result = new char[s.Length];
      int wordStartIndex;
      bool spaceBreak = true;

      wordStartIndex = 0;
      for(int i = 0; i < result.Length; i++) {
        if(spaceBreak) {
          wordStartIndex = i;
          spaceBreak = false;
        }

        if(s[i] == ' ') {
          ReverseToFrom(result, ref s, wordStartIndex, i - 1);
          result[i] = ' ';
          spaceBreak = true;
        }

        if(i == result.Length - 1) {
          ReverseToFrom(result, ref s, wordStartIndex, i);
        }
      }

      return new string(result);
    }

    private void ReverseToFrom(char[] arr, ref string s, int start, int end) {
      for(int i = start, i2 = end; i <= end; i++, i2--) {
        arr[i] = s[i2];
      }
    }
  }
}