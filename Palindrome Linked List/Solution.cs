using LeetCodeHelper;

namespace Palindrome_Linked_List {
    internal class Solution {
        public bool IsPalindrome(ListNode head) {
            if(head == null || head.next == null) { return true; }

            ListNode reversed = Reverse(head);

            while(head != null) {
                if(head.val != reversed.val) { return false; }
                head = head.next;
                reversed = reversed.next;
            }

            return true;
        }

        private ListNode Reverse(ListNode head) {
            ListNode reversed, previous;
            reversed = previous = null;

            while(head != null) {
                previous = reversed;
                reversed = new ListNode(head.val);
                reversed.next = previous;
                head = head.next;
            }

            return reversed;
        }
    }
}