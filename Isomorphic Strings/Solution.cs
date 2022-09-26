using System.Collections.Generic;

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        var chars = new Dictionary<char, char>();
        char firstChar, secondChar;
        bool isFirstCharInKeys;

        for(int i = 0; i < s.Length; i++) {
            firstChar = s[i];
            secondChar = t[i];
            isFirstCharInKeys = IsFirstCharInKeys(ref chars, firstChar);

            if(!isFirstCharInKeys && !chars.ContainsValue(secondChar)) {
                chars.Add(firstChar, secondChar);
            } else if(!isFirstCharInKeys || chars[firstChar] != secondChar) {
                return false;
            }
        }

        return true;
    }

    private bool IsFirstCharInKeys(ref Dictionary<char, char> chars, char firstChar) {
        return chars.ContainsKey(firstChar);
    }
}
