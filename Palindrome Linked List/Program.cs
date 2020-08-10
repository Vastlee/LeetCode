using System;
using System.Collections.Generic;
using LeetCodeHelper;

namespace Palindrome_Linked_List {
    internal class Program {
        private static void Main(string[] args) {
            ListNode l1 = HelperMethods.CreateLinkedList(new int[] { 1, 2, 3, 2, 1 });
            ListNode l2 = HelperMethods.CreateLinkedList(new int[] { 1, 9, 8, 8 });
            ListNode l3 = HelperMethods.CreateLinkedList(new int[] { 1 });
            ListNode l4 = HelperMethods.CreateLinkedList(new int[] { });

            var solve = new Solution();

            Console.WriteLine(solve.IsPalindrome(l1));
            Console.WriteLine(solve.IsPalindrome(l2));
            Console.WriteLine(solve.IsPalindrome(l3));
            Console.WriteLine(solve.IsPalindrome(l4));
        }

        static private IEnumerable<ListNode> Nodes(ListNode head) {
            while(head != null) {
                yield return head;
                head = head.next;
            }
        }
    }
}