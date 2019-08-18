namespace Delete_Node_in_a_Linked_List {
  internal static class Program {
    private static void Main(string[] args) {
      ListNode head = new ListNode(4);
      head.next = new ListNode(5);
      head.next = new ListNode(1);
      head.next = new ListNode(9);
      head.next = head;
    }
  }
}