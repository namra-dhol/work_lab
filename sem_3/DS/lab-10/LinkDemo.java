
 class LL{
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

    void deleteFirst() {
        if (first == null) {
            System.out.println("underflow");
            return;
        }
        first = first.link;
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

    void deleteLast() {
        Node temp = first;
        while (temp.link.link != null) {
            temp = temp.link;
        }
        temp.link = null;
    }

    public void deleteIndex(int index) {
        Node temp = first;

        for (int i = 1; i < index - 1; i++) {
            temp = temp.link;
        }
        temp.link = temp.link.link;
    }
    int countNode(){
        Node temp = first;
        int count=0;
        while (temp!= null) {
            count++;
            temp = temp.link;
        }
        return count;
    }
}

public class LinkDemo {
    public static void main(String[] args) {
        LL list = new LL();
        list.insertAtFirst(10);
        list.display();
        list.insertAtFirst(20);
        list.display();
        list.insertAtFirst(30);
        list.display();
        list.insertAtEnd(40);
        list.display();
        list.deleteFirst();
        list.display();
        list.insertAtEnd(50);
        list.display();
        list.insertAtEnd(60);
        list.display();
        list.deleteLast();
        list.display();
        list.deleteIndex(3);
        list.display();
        System.out.println(list.countNode());
    }
}