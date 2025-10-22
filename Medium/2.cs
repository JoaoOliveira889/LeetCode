/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyList = new(0);
        ListNode current = dummyList;
        int carry = 0;

        while(l1 != null || l2 != null || carry != 0)
        {
            int l1Digt = l1 != null ? l1.val : 0;
            int l2Digt = l2 != null ? l2.val : 0;

            int sum = l1Digt + l2Digt + carry;
            int digSum = sum %10;
            carry = sum /10;

            current.next = new ListNode(digSum);
            current = current.next;

            if(l1 != null)
                l1 = l1.next;
            if(l2 != null)
                l2 = l2.next;
        }

        return dummyList.next;
    }
}