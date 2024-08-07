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
    public void insertAtFirst(int data){
        Node newNode = new Node(data);

        if(first==null){
            first = newNode;
            tail=newNode;
            count++;
            return;
        }
        else{
            first.lpter=newNode;
            newNode.rpter=first;
            first=newNode;
            newNode.lpter = null;
            count++;
        }
    }

    public void insertAtLast(int data){
        Node newNode = new Node(data);

        if(first==null){
            first=newNode;
            tail=newNode;
            count++;
            return;
        }
        else{
            tail.rpter =newNode;
            newNode.lpter=tail;
            tail = newNode;
            count++;
        }
    }

    public void deleteAtPosition(int n){
        
    }

    public void countNode(){
        System.out.println("count is ::: "+count);
    }


    public void display(){
        Node save = first;
        while(save.rpter!=null){
            System.out.print(save.info+"->");
            save=save.rpter;
        }
        System.out.print(save.info+"->");
        System.out.print("null");
    }

}
