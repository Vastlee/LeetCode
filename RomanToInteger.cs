namespace LeetCode;

internal static class RomanToInteger {
    static Solution solve = new();

    public static void RunTests() {
        Console.WriteLine("Input: III");
        Console.WriteLine("Expected Ouput: 3");
        Console.WriteLine($"Output: {solve.RomanToInt("III")}");
        Console.WriteLine();

        Console.WriteLine("Input: LVIII");
        Console.WriteLine("Expected Ouput: 58");
        Console.WriteLine($"Output: {solve.RomanToInt("LVIII")}");
        Console.WriteLine();

        Console.WriteLine("Input: MCMXCIV");
        Console.WriteLine("Expected Ouput: 1994");
        Console.WriteLine($"Output: {solve.RomanToInt("MCMXCIV")}");
        Console.WriteLine();
    }

    class Solution {
        static Dictionary<char, int> Numerals = new() {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        static HashSet<char> Reducers = new() { 'I', 'X', 'C' };

        static Dictionary<string, int> Reductions = new() {
            { "IV", 1 },
            { "IX", 1 },
            { "XL", 10 },
            { "XC", 10 },
            { "CD", 100 },
            { "CM", 100 },
        };

        public int RomanToInt(string s) {
            int result = 0;
            string next;

            for(int i = 0; i < s.Length; i++) {
                if(Reducers.Contains(s[i]) && !IsNextToLastIndex(s, i)) {
                    next = s[i].ToString() + s[i + 1].ToString();
                    if(Reductions.ContainsKey(next)) {
                        result -= Reductions[next];
                        continue;
                    }
                }
                result += Numerals[s[i]];
            }
            return result;

            static bool IsNextToLastIndex(string s, int i) => (i + 1) == s.Length;
        }
    }
}
