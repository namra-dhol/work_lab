public class DLL {
    class Node {
        int info;
        Node lpter;
        Node rpter;

        public Node(int data) {
            this.info = data;
            this.lpter = null;
            this.rpter = null;
        }
    }

    int count = 0;
    Node head = null;
    Node first = null;
    Node tail = null;

    public void insertAtFirst(int data) {
        Node newNode = new Node(data);

        if (first == null) {
            first = newNode;
            tail = newNode;
            count++;
            return;
        } else {
            first.lpter = newNode;
            newNode.rpter = first;
            first = newNode;
            newNode.lpter = null;
            count++;
        }
    }

    public void insertAtLast(int data) {
        Node newNode = new Node(data);

        if (first == null) {
            first = newNode;
            tail = newNode;
            count++;
            return;
        } else {
            tail.rpter = newNode;
            newNode.lpter = tail;
            tail = newNode;
            count++;
        }
    }

    // public void deleteAtPosition(int n) {
    // if (first == null) {
    // System.out.println("linked list is empty :: ");
    // return;
    // }
    // else {
    // int temp = 1;
    // Node save = first;

    // while ((temp < n) && save.rpter != null) {
    // save = save.rpter;
    // temp++;
    // }
    // if(save==null){
    // System.out.println("node not found ::");
    // }
    // else if{

    // if (save==tail) {
    // tail.rpter.lpter=null;
    // }
    // }
    // else{
    // save.lpter.rpter = save.rpter;
    // save.rpter.lpter = save.lpter;
    // }
    // }
    // }

    public void deleteAtPosition(int n) {
        if (first == null) {
            System.out.println("Linked list is empty.");
            return;
        }

        int temp = 1;
        Node save = first;

        while ((temp < n) && save.rpter != null) {
            save = save.rpter;
            temp++;
        }

        if (temp != n) {
            System.out.println("Node not found.");
            return;
        }

        if (save == first) {
            first = save.rpter;
            if (first != null) {
                first.lpter = null;
            } else {
                tail = null;
            }
        }
        else if (save == tail) {
            tail = save.lpter;
            if (tail != null) {
                tail.rpter = null;
            } else {
                first = null;
            }
        }
        else {
            save.lpter.rpter = save.rpter;
            save.rpter.lpter = save.lpter;
        }
    }

    public void countNode() {
        System.out.println("count is ::: " + count);
    }

    public void display() {
        Node save = first;
        while (save.rpter != null) {
            System.out.print(save.info + "->");
            save = save.rpter;
        }
        System.out.print(save.info + "->");
        System.out.print("null");
    }

}
