using System;
using LeetCodeHelper;

namespace Maximum_Depth_of_Binary_Tree;

internal static class Program {
    private static void Main(string[] args) {
        var t1 = Helper.AddLeaves(new int[] { 3, 1, 2, 5, 4 });
        var toList = Helper.TreeToList(t1);
        foreach(var node in toList) {
            Console.WriteLine($"{node.Value}, ");
        }
    }
}
