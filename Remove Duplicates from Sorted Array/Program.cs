using System;

namespace Remove_Duplicates_from_Sorted_Array {
    class Program {
        static void Main(string[] args) {
            var solution = new Solution();

            int[] input = new int[] { 1, 1, 1, 2, 3, 4 };
            int result = solution.RemoveDuplicates(input);
            for (int i = 0; i < input.Length; i++) {
                Console.Write(input[i]);
                if (i < input.Length) { Console.Write(", "); }
            }
            Console.WriteLine();
            Console.WriteLine($"Count: {result.ToString()}");
        }
    }
}