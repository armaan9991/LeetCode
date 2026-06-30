  public class ListNode {
      public int val;
     public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
 
public class Has_cycle_141 {
    public bool HasCycle(ListNode head) {
        ListNode one = head;
        ListNode two = head;
        while(two != null && two.next != null){
            one = one.next;
            two = two.next.next;
            if(one == two){
                return true;
            }
        }
        return false;
    }
}