using System.Text;

namespace LeetCodeHelper;

public static class Helper {
    public static TreeNode AddLeaves(int[] nums, TreeNode root = null, int startIndex = 0) {
        if(root == null && nums.Length > 0) {
            root = new TreeNode(nums[startIndex]);
            startIndex++;
        }

        while(startIndex <= nums.Length) {
            AddLeaf(root, startIndex++);
        }

        return root;
    }

    public static TreeNode AddLeaf(TreeNode root, int value) {
        if(root == null) {
            root = new TreeNode(value);
        } else {
            if(value <= root.Value) {
                root.Left = AddLeaf(root.Left, value);
            } else {
                root.Right = AddLeaf(root.Right, value);
            }
        }

        return root;
    }

    public static List<TreeNode> TreeToList(TreeNode root, List<TreeNode> list = null) {
        if(list == null) {
            list = new List<TreeNode>();
        }

        if(root != null) {
            list.Add(root);
            TreeToList(root.Left);
            TreeToList(root.Right);
        }

        return list;
    }

    public static string LinkedListToString(ListNode head) {
        var result = new StringBuilder();
        while(head != null) {
            result.Append($"{head.Value.ToString()}" +
                $"{((head.Next != null) ? "," : "")}");
            head = head.Next;
        }
        return result.ToString();
    }

    public static ListNode LinkedListFromArray(int[] arr) {
        ListNode head, newNode;
        head = newNode = null;

        foreach(int value in arr) {
            newNode = new(value);
            if(head == null) { head = newNode; }
            newNode = newNode.Next;
        }

        return head;
    }
}