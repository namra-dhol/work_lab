public class Lab10_1 {
    public static void main(String[] args) {
        SLL s1 = new SLL();
        s1.insertAtFirst(10);
        s1.insertAtFirst(20);
        s1.insertAtFirst(30);
        s1.insertAtFirst(40);
        s1.insertAtFirst(50);
        s1.display();
        s1.insertAtLast(25);
        s1.deleteFirst();
        s1.deleteLast();
        s1.display();
    }
}