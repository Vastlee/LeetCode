using System;

namespace Remove_Duplicates_from_Sorted_Array {
    class Program {
        static void Main(string[] args) {
            int result = Solution.RemoveDuplicates(new int[] { 1, 1, 1, 2, 3, 4 });
            Console.WriteLine(result.ToString());
        }
    }
}