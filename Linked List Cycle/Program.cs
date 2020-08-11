using System;
using LeetCodeHelper;

namespace Linked_List_Cycle {
    class Program {
        static void Main(string[] args) {
            ListNode l1 = HelperMethods.CreateLinkedList(new int[] { 1, 2, 3, 2, 1 });
            ListNode l2 = HelperMethods.CreateLinkedList(new int[] { 1, 9, 8, 8 });
            ListNode l3 = HelperMethods.CreateLinkedList(new int[] { 1 });
            ListNode l4 = HelperMethods.CreateLinkedList(new int[] { });

            var solve = new Solution();

            Console.WriteLine(solve.HasCycle(l1));
        }
    }
}
