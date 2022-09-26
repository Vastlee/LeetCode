using LeetCodeHelper;

using Add_Two_Numbers;

int[] firstNums = { 2, 4, 3 };
ListNode firstList = Helper.LinkedListFromArray(firstNums);

Solution solve = new();

ListNode current = firstList;

while(current != null) {
    Console.WriteLine(current.Value);
    current = current.Next;
}