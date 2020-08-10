using System;
using System.Text;

namespace LeetCodeHelper {
    public static class HelperMethods {
        public static ListNode CreateLinkedList(int[] nums) {
            ListNode head, newNode, lastNode;
            head = lastNode = null;

            for(int i = 0; i < nums.Length; i++) {
                newNode = new ListNode(nums[i]);

                if(i == 0) {
                    head = newNode;
                } else {
                    lastNode.next = newNode;
                }

                lastNode = newNode;
            }
            return head;
        }

        public static string LinkedListToString(ListNode head) {
            var result = new StringBuilder();
            while(head != null) {
                result.Append($"{head.val.ToString()}" +
                    $"{((head.next != null) ? "," : "")}");
                head = head.next;
            }
            return result.ToString();
        }
    }
}
