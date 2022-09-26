using System;

namespace Isomorphic_Strings {
    internal class Program {

        private static void Main(string[] args) {
            var solve = new Solution();

            var inputs = new string[][] {
                new string[] { "egg", "add" }
            };

            foreach(var input in inputs) {
                Console.WriteLine($"{solve.IsIsomorphic(input[0], input[1])}");
            }
        }
    }
}