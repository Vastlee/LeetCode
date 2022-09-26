using System.Text;
using LeetCodeHelper;

namespace Add_Two_Numbers;

public sealed class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head, newNode;
        head = null;

        int sum = 0;
        while(l1 != null && l2 != null) {
            if(l1 != null) {
                sum += l1.Value;
                l1 = l1.Next;
            }
            if(l2 != null) {
                sum += l2.Value;
                l2 = l2.Next;
            }

            newNode = new(sum);
            head ??= newNode;
            newNode = newNode.Next;
        }

        return head;
    }

    public ListNode ReverseLinkedListRecursive(ListNode head) {
        if(head != null) {
            ListNode unoReverse = head;
            ReverseLinkedListRecursive(head.Next);
            head.Next = unoReverse;
        }
        return head;
    }

    public int LinkedListToReversedInt(ListNode head) {
        int placeMultiplier = 1;
        int total = 0;
        int multiplierBase = 10;

        while(head != null) {
            total += head.Value * placeMultiplier;
            placeMultiplier *= multiplierBase;
            head = head.Next;
        }
        return total;
    }
}