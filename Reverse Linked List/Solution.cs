using System;

class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) { return head; }

        ListNode nextNode, previousNode;
        nextNode = previousNode = null;

        while(head.next != null) {
            nextNode = head.next;
            head.next = previousNode;
            previousNode = head;
            head = nextNode;
        }

        head.next = previousNode;
        return head;
    }

    private void PrintStatus(ListNode head, ListNode nextNode, ListNode previousNode) {
        string tmpNodeStatus, previousNodeStatus, headStatus;

        tmpNodeStatus = (nextNode == null) ? "null" : nextNode.val.ToString();
        previousNodeStatus = (previousNode == null) ? "cull" : previousNode.val.ToString();
        headStatus = (head == null) ? "null" : head.val.ToString();

        Console.WriteLine($"t: {tmpNodeStatus} p: {previousNodeStatus} h: {headStatus}");
    }
}
