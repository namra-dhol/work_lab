import org.w3c.dom.Node;

class LL3 {
    class Node {
        int info;
        Node link;

        public Node(int data) {
            this.info = data;
            this.link = null;
        }
    }

    public Node first = null;

    void insertAtFirst(int x) {
        Node newNode = new Node(x);
        if (first == null) {
            first = newNode;
            return;
        } else {
            newNode.link = first;
            first = newNode;
        }
    }

    void display() {
        Node temp = first;
        while (temp != null) {
            System.out.print(temp.info + " ");
            temp = temp.link;
        }
        System.out.println("");
    }

    void insertAtEnd(int x) {
        Node newNode = new Node(x);
        if (first == null) {
            first = newNode;
            return;
        } else {
            Node temp = first;
            while (temp.link != null) {
                temp = temp.link;
            }
            temp.link = newNode;
        }
    }
    void sortList(){
        if (first == null) {
            System.out.println("underflow");
            return;
        }
        else{
            Node prev=first;
            Node next=first;
            while(prev.link!=null){
                next=prev;
                while(next.link!=null){
                    next=next.link;
                    if(prev.info>next.info){
                        int temp=prev.info;
                        prev.info=next.info;
                        next.info=temp;
                    }
                }
                prev=prev.link;
            }
        }
    }
}
public class sortLL {
    public static void main(String[] args) {
        LL3 l1 = new LL3();
        l1.insertAtFirst(10);
        l1.insertAtEnd(50);
        l1.insertAtEnd(34);
        l1.insertAtEnd(23);
        l1.insertAtEnd(90);
        l1.insertAtEnd(20);
        l1.insertAtEnd(80);
        l1.insertAtEnd(1);
        l1.sortList();
        l1.display();
    }
}
