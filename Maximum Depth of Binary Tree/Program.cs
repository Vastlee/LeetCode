using System;

namespace Maximum_Depth_of_Binary_Tree {
  internal static class Program {
    private static void Main(string[] args) {
      var head = new TreeNode(1);
      head.left = new TreeNode(2);
      head.right = new TreeNode(3);
      head.right.right = new TreeNode(4);
      head.right.right.right = new TreeNode(5);

      Console.WriteLine(new Solution().MaxDepth(head));
    }
  }
}