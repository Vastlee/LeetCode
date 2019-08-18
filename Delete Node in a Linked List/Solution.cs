namespace Delete_Node_in_a_Linked_List {
  internal class Solution {
    public void DeleteNode(ListNode node) {
      node.val = node.next.val;
      node.next = node.next.next;
    }
  }
}