class LL2 {
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

    void reverce() {
        if (first == null) {
            System.out.println("Linked list does not exist");
            return;
        } else {
            Node curr = first;
            Node prev = null;
            Node new1 = null;
            while (curr != null) {
                new1 = curr.link;
                curr.link = prev;
                prev = curr;
                curr = new1;
            }
            curr.link=prev;
            first=curr;
        }
    }
}

public class reverce {
    public static void main(String[] args) {
        LL2 l1 = new LL2();
        l1.insertAtFirst(10);
        l1.insertAtEnd(20);
        l1.insertAtEnd(20);
        l1.insertAtEnd(30);
        l1.insertAtEnd(30);
        l1.insertAtEnd(40);
        l1.insertAtEnd(45);
        l1.insertAtEnd(45);
        l1.display();
        l1.reverce();
        l1.display();
    }
}
