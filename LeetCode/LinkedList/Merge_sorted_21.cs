
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
public class Merge_sorted_21 {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head= null;
        if(list1 != null && list2 !=null){
            if(list1.val <= list2.val){
                head = list1;
                list1 = list1.next;
            }else{
                head = list2;
                list2 = list2.next;
            }
        }else if(list1 != null){
            head = list1;
            list1 = list1.next;
        }
        else if(list2 != null){
            head = list2;
            list2 = list2.next;
        }
        ListNode curr = head;
        while(list1 != null && list2 != null){
            if(list1.val <= list2.val){
                curr.next = list1;
                list1 = list1.next;
                curr = curr.next;
            }
            else{
                curr.next = list2;
                list2 = list2.next;
                curr = curr.next;
            }
        } 
        while(list1 != null){
            curr.next = list1;
            list1 = list1.next;
            curr = curr.next;
        }
        while(list2 != null){
            curr.next = list2;
            list2 = list2.next;
            curr = curr.next;
        }

        return head; 
    }
}