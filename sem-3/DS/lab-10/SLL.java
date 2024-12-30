public class SLL {
   
    class Node{
        int info;
        Node next;

        Node(int data){
            this.info = data;
            this.next=null;
        }

    }
    int count = 0;
    // public SLL(){
    //     this.count=0;
    // }
    public Node first=null;
    
    public void insertAtFirst(int data){ 
        Node n1 = new Node(data);

        if(first==null){
            first = n1;
            return;
        }
        n1.next = first;
        first = n1;

        count++;
    }

    public void insertAtLast(int data){
        Node n1 = new Node(data);

        if(first==null){
            first = n1;
            return;
        }

        Node save = first;

        while (save.next!=null) {
            save = save.next;
        }
        save.next = n1;
        count++;
    }
    public void deleteLast(){
        if(first == null){
            System.out.println("list is empty");
        }
        else{
            Node save = first;

            while (save.next.next!=null) {
                save = save.next;
            }
            save.next=null;
        }
        count--;

    }
    public void display(){
        Node temp =first;
        System.out.println("");
        while (temp!=null) {
            System.out.print(temp.info+"-->");
            temp=temp.next;
        }
        System.out.print("null");
        // System.out.println("No of nodes = " + count);
    }

    public void deleteFirst(){
        if(first==null){
            System.out.println("list is empty");
        }
        else{
            first=first.next;
        }
        count--;
    }

    public void deleteAtPositation(){

        

    }


}
