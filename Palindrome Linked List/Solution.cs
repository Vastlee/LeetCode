using LeetCodeHelper;

namespace Palindrome_Linked_List {
    internal class Solution {
        public bool IsPalindrome(ListNode head) {
            if(head == null || head.Next == null) { return true; }

            ListNode reversed = Reverse(head);

            while(head != null) {
                if(head.Value != reversed.Value) { return false; }
                head = head.Next;
                reversed = reversed.Next;
            }

            return true;
        }

        private ListNode Reverse(ListNode head) {
            ListNode reversed, previous;
            reversed = previous = null;

            while(head != null) {
                previous = reversed;
                reversed = new ListNode(head.Value);
                reversed.Next = previous;
                head = head.Next;
            }

            return reversed;
        }
    }
}