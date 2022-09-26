using LeetCodeHelper;

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head == null) { return null; }

        int len = ListLength(head);

        RemoveNth(ref head, (len + 1) - n);

        return head;
    }

    public void RemoveNth(ref ListNode head, int n) {
        if(head == null) { return; }
        if(n == 1) {
            head = head.Next;
            return;
        }

        ListNode current = head;
        ListNode last = head;

        for(int i = 1; i < n; i++) {
            last = current;
            current = current.Next;
        }

        last.Next = current.Next;
    }

    private int ListLength(ListNode head) {
        int result = 0;
        ListNode current = head;
        while(current != null) {
            result++;
            current = current.Next;
        }
        return result;
    }
}