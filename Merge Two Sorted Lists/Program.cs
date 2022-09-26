using LeetCodeHelper;

namespace Merge_Two_Sorted_Lists;

public class Program {
    public static void Main(string[] args) {
        ListNode l1 = Helper.LinkedListFromArray(new int[] { 5 });
        ListNode l2 = Helper.LinkedListFromArray(new int[] { 1, 2, 4, 100, 101 });

        ListNode merged = new Solution().MergeTwoLists(l1, l2);

        Console.WriteLine($"{Helper.LinkedListToString(merged)}");
    }
}
