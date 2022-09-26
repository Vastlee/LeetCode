using System;

namespace Custom_Sort_String {
    class Program {
        static void Main(string[] args) {
            var solve = new Solution();
            string order = "kqep";
            string s = "pekeq";
            Console.WriteLine(solve.CustomSortString(order, s));
        }
    }
}
