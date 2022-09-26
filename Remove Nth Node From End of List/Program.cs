using System;
using LeetCodeHelper;

internal static class Program {
    private static void Main(string[] args) {
        var solve = new Solution();

        ListNode head;
        ListNode current;

        current = new ListNode(1);
        head = current;

        for(int i = current.Value + 1; i < 10; i++) {
            current.Next = new ListNode(i);
            current = current.Next;
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
            Console.Write($"{current.Value}");
            if(current.Next != null) {
                Console.Write($"{delimiter}");
            }
            current = current.Next;
        }
        Console.WriteLine();
    }

    private static int Length(ListNode head) {
        int result = 0;
        ListNode current = head;
        while(current != null) {
            result++;
            current = current.Next;
        }
        return result;
    }
}