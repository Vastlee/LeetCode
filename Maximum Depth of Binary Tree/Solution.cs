namespace Maximum_Depth_of_Binary_Tree {
  internal class Solution {
    public int MaxDepth(TreeNode root) {
      if(root != null) {
        int maxLeft = MaxDepth(root.left);
        int maxRight = MaxDepth(root.right);

        return (maxLeft > maxRight) ? ++maxLeft : ++maxRight;
      }

      return 0;
    }
  }

  public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) {
      val = x;
    }
  }
}