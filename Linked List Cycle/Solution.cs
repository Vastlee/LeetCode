using System.Collections.Generic;
using LeetCodeHelper;

namespace Linked_List_Cycle {
    internal class Solution {
        public bool HasCycle(ListNode head) {
            var map = new HashSet<ListNode>();

            while(head != null) {
                if(map.Contains(head)) { return true; }
                map.Add(head);
                head = head.Next;
            }

            return false;
        }
    }
}
