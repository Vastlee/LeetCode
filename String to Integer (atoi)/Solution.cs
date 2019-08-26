using System;

namespace String_to_Integer__atoi_ {
  internal class Solution {
    public int MyAtoi(string str) {
      int result = 0;
      char[] strAsChars = str.ToCharArray();
      ReadOnlySpan<char> resultChars;
      bool isSigned = false;
      bool isNegative = false;

      int startIndex = -1;
      int len = 0;
      for(int i = 0; i < strAsChars.Length; i++) {
        if(startIndex == -1) {
          char c = strAsChars[i];

          if(char.IsWhiteSpace(c)) { continue; }

          if(IsValidStartCharacter(c)) {
            startIndex = i;
            len = 1;

            isNegative = (c == '-');
            isSigned = (c == '-' || c == '+');
          } else {
            return 0;
          }
        } else {
          if(char.IsDigit(strAsChars[i])) {
            len++;
          } else {
            break;
          }
        }
      }

      if(startIndex == -1 || (isSigned && len < 2)) { return 0; }

      resultChars = new Span<char>(strAsChars, startIndex, len);

      if(int.TryParse(resultChars, out result)) {
        return result;
      }

      if(isNegative) {
        return int.MinValue;
      } else {
        return int.MaxValue;
      }
    }

    private bool IsValidStartCharacter(char c) {
      return
        char.IsDigit(c)
        || c == '-'
        || c == '+';
    }
  }
}