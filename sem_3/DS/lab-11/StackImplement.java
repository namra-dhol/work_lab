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

    void display() {
        Node temp = first;
        while (temp != null) {
            System.out.print(temp.info + " ");
            temp = temp.link;
        }
        System.out.println("");
    }

    void push(int x) {
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

    int pop() {
        Node temp = first;
        int ans = 0;
        while (temp.link.link != null) {
            temp = temp.link;
            ans = temp.info;
        }
        temp.link = null;
        return ans;
    }

    int countNode() {
        Node temp = first;
        int count = 0;
        while (temp != null) {
            count++;
            temp = temp.link;
        }
        return count;
    }

    public int peep(int index) {
        int ans = 0;
        if ((countNode() - index + 1) <= 0) {
            System.out.println("underflow");
            return 0;
        }
        else if((countNode()-index)==1){
            int ans2=first.link.info;
            first.link=first.link.link;
            return ans2;
        }
        else if((countNode()-index)==0){
            int ans3=first.info;
            first=first.link;
            return ans3;
        }
        else {
            Node temp = first;
            for (int i = 1; i < (countNode() - index); i++) {
                temp = temp.link;
                ans = temp.link.info;
            }
            temp.link = temp.link.link;
        }
        return ans;
    }

    void change(int index, int n) {
        if ((countNode() - index + 1) <= 0) {
            System.out.println("underflow");
            return;
        }
        else if(countNode()-index==0){
            first.info=n;
        }
        else {
            Node temp = first;
            for (int i = 1; i < (countNode() - index); i++) {
                temp = temp.link;
            }
            temp.link.info=n;
        }
    }
}

public class StackImplement {
    public static void main(String[] args) {
        LL2 list = new LL2();
        list.push(10);
        list.push(20);
        list.push(25);
        list.push(40);
        list.display();
        list.pop();
        list.display();
        list.push(10);
        list.push(20);
        list.push(30);
        list.push(40);
        list.display();
        System.out.println(list.peep(5));
        list.display();
        list.change(6, 50);
        list.display();
    }
}
