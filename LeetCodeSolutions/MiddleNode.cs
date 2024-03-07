namespace LeetCodeSolutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static  class MiddleNode
    {
        public static ListNode Solution(ListNode head)
        {
            ListNode middleNode = head;
            ListNode endNode = head;
            while (endNode != null && endNode.next != null)
            {
                middleNode = middleNode.next;
                endNode = endNode.next.next;
            }

            return middleNode;
        }        
    }
}
