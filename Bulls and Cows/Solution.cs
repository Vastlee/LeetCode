using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string GetHint(string secret, string guess) {
        int bulls, cows;
        var secretArr = secret.ToCharArray();
        var guessArr = guess.ToCharArray();

        bulls = CountAndMarkBulls(secretArr, guessArr);
        cows = CountAndMarkCows(secretArr, guessArr);
        return $"{bulls}A{cows}B";
    }

    private int CountAndMarkBulls(char[] secret, char[] guess) {
        int result = 0;
        for(int i = 0; i < secret.Length; i++) {
            if(secret[i] == guess[i]) {
                result++;
                secret[i] = ' ';
                guess[i] = ' ';
            }
        }
        return result;
    }

    private int CountAndMarkCows(char[] secret, char[] guess) {
        int result = 0;
        for(int i = 0; i < secret.Length; i++) {
            if(guess[i] == ' ') { continue; }
            if(FindAndMarkCow(secret, guess[i])) {
                guess[i] = ' ';
                result++;
            }
        }
        return result;
    }

    private bool FindAndMarkCow(char[] secret, char guess) {
        for(int i = 0; i < secret.Length; i++) {
            if(secret[i] == ' ') { continue; }
            if(secret[i] == guess) {
                    secret[i] = ' ';
                    return true;
            }
        }
        return false;
    }
}
