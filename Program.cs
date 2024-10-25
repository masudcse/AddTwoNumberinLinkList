
//Definition for singly - linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
    }
}


public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode tempHead =new ListNode(0);
        ListNode currentHead = tempHead;
        int carry = 0;
        while(l1!=null || l2!=null || carry != 0)
        {
            int sum = carry;
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            carry = sum / 10;
            currentHead.next =new ListNode(sum % 10);
            currentHead = currentHead.next;

        }
        return tempHead.next;
    }
    public static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val);
            if (node.next != null) Console.Write(" -> ");
            node = node.next;
        }
        Console.WriteLine();
    }
    public static ListNode CreateList(int[] values)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        foreach (int value in values)
        {
            current.next = new ListNode(value);
            current = current.next;
        }
        return dummyHead.next;
    }

    public static void Main()
    {
        // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        ListNode l1 = CreateList(new int[] { 2, 4, 3 });
        ListNode l2 = CreateList(new int[] { 5, 6, 4 });

        Solution solution = new Solution();
        ListNode result = solution.AddTwoNumbers(l1, l2);

        // Expected Output: 7 -> 0 -> 8
        Console.Write("Output: ");
        PrintList(result);
    }


}