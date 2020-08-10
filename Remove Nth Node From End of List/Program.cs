using System;
using LeetCodeHelper;

internal static class Program {
    private static void Main(string[] args) {
        var solve = new Solution();

        ListNode head;
        ListNode current;

        current = new ListNode(1);
        head = current;

        for(int i = current.val + 1; i < 10; i++) {
            current.next = new ListNode(i);
            current = current.next;
        }

        Log(head);
        head = solve.RemoveNthFromEnd(head, 1);
        Log(head);
        head = solve.RemoveNthFromEnd(head, 1);
        Log(head);
    }

    public static void Log(ListNode head) {
        ListNode current = head;
        string delimiter = ", ";
        while(current != null) {
            Console.Write($"{current.val}");
            if(current.next != null) {
                Console.Write($"{delimiter}");
            }
            current = current.next;
        }
        Console.WriteLine();
    }

    private static int Length(ListNode head) {
        int result = 0;
        ListNode current = head;
        while(current != null) {
            result++;
            current = current.next;
        }
        return result;
    }
}