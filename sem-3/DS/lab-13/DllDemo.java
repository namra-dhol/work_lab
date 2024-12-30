public class DllDemo {
    public static void main(String[] args) {
        DLL d1 = new DLL();
        d1.insertAtFirst(25);
        d1.insertAtFirst(40);
        d1.insertAtFirst(35);
        d1.insertAtFirst(45);
        d1.insertAtLast(60);
        d1.display();
        System.out.println();
        d1.countNode();
        d1.deleteAtPosition(2);
        System.out.println();
        d1.display();
    }
   
}