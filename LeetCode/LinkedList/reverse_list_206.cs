
//  * Definition for singly-linked list.
 public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
 }
 
public class reverse_list_206 {
    public ListNode ReverseList(ListNode head) {
        // prev is to keep track for previous node
        ListNode prev = null;
        // curr to track current node
        ListNode curr = head;
        //while we dont reach till end.
        while(curr != null){
            ListNode n=curr.next;       // we store next node in n first
            curr.next = prev;           // then we change the pointer and point it in prev direction.
            prev = curr;                // now we update our prev node with current one
            curr = n;                   // and update current one with next one and move ahead in list 
        }
        return  prev;                   // return head of reversed head.
    }
}