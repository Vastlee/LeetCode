using LeetCodeHelper;

namespace Merge_Two_Sorted_Lists {
    internal class Solution {
        internal ListNode MergeTwoLists(ListNode l1, ListNode l2) {
            ListNode head, stitch;
            head = stitch = new ListNode();

            while(l1 != null && l2 != null) {
                if(l1.Value <= l2.Value) {
                    stitch.Next = l1;
                    l1 = l1.Next;
                } else {
                    stitch.Next = l2;
                    l2 = l2.Next;
                }
                stitch = stitch.Next;
            }

            stitch.Next = l1 ?? l2;

            return head.Next;
        }
    }
}
