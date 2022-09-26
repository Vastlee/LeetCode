using LeetCodeHelper;

namespace Delete_Node_in_a_Linked_List {
  internal class Solution {
    public void DeleteNode(ListNode node) {
      node.Value = node.Next.Value;
      node.Next = node.Next.Next;
    }
  }
}