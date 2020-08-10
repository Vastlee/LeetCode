using LeetCodeHelper;

namespace Palindrome_Linked_List {
    internal class Solution {
        public bool IsPalindrome(ListNode head) {
            return false;
        }

        private ListNode Reverse(ListNode head) {
            ListNode previous, next;

            while(head.next != null) {
                previous = head;
                head = head.next;
                next = head.next;
                head.next = previous;
                head = next;
            }

            return head;
        }
    }
}
