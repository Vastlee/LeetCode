namespace Remove_Nth_Node_From_End_of_List {
  internal class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
      if(head == null) { return null; }

      int len = ListLength(head);

      RemoveNth(ref head, (len + 1) - n);

      return head;
    }

    internal void RemoveNth(ref ListNode head, int n) {
      if(head == null) { return; }
      if(n == 1) {
        head = head.next;
        return;
      }

      ListNode current = head;
      ListNode last = head;

      for(int i = 1; i < n; i++) {
        last = current;
        current = current.next;
      }

      last.next = current.next;
    }

    private int ListLength(ListNode head) {
      int result = 0;
      ListNode current = head;
      while(current != null) {
        result++;
        current = current.next;
      }
      return result;
    }
  }
}