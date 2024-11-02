//O(N)
//O(1)
public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        while (head != null && head.val == val)
        {
            head = head.next;
        }

        if (head == null) return null;

        var node = head;
        while (node.next != null)
        {
            if (node.next.val == val)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }

        return head;
    }
}
