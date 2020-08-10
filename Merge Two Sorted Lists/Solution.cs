using LeetCodeHelper;

namespace Merge_Two_Sorted_Lists {
    internal class Solution {
        internal ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            ListNode head, stitch;
            head = stitch = new ListNode();

            while(l1 != null && l2 != null) {
                if(l1.val <= l2.val) {
                    stitch.next = l1;
                    l1 = l1.next;
                } else {
                    stitch.next = l2;
                    l2 = l2.next;
                }
                stitch = stitch.next;
            }

            stitch.next = l1 ?? l2;

            return head.next;
        }
    }
}
