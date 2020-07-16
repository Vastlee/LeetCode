using System;

class Program {
    static void Main(string[] args) {
        var solve = new Solution();
        ListNode head = new ListNode(0);
        ListNode cNode = head;

        for(int i = cNode.val + 1; i <= 5; i++) {
            cNode.next = new ListNode(i);
            cNode = cNode.next;
        }

        head = solve.ReverseList(head);

        while(head != null) {
            Console.WriteLine($"{head.val}");
            head = head.next;
        }
    }
}
