class QueueClass {
    int r;
    int f;
    int[] arr;
    int n;

    QueueClass(int n) {
        this.f = -1;
        this.r = -1;
        this.n = n;
        arr = new int[n];
    }

    public void insert(int x) {
        if ((r == n && f == 0) || (r + 1 == f)) {
            System.out.println("overflow");
            return;
        }
        if (r == -1 && f == -1) {
            f++;
            r++;
        }
        r %= n;
        arr[r++] = x;
    }

    public int delete() {
        if (r == f && f == 0) {
            System.out.println("underflow");
            return -1;
        } else {
            int y = arr[++f];
            return y;
        }
    }

    public void printData() {
        if (f == -1 && r == -1) {
            return;
        }
        for (int i = f; i < n; i++) {
            System.out.println(arr[i]);
        }
        for (int i = 0; i < r; i++) {
            System.out.println(arr[i]);
        }
    }
}

public class CirQueue {
    public static void main(String[] args) {
        QueueClass q1 = new QueueClass(5);

        q1.insert(0);
        q1.insert(1);
        q1.insert(2);
        q1.insert(3);
        q1.insert(4);
        q1.delete();
        q1.insert(10);
        q1.printData();
    }
}