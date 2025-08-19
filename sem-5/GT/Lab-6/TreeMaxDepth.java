import java.util.ArrayList;
import java.util.List;

class Node {
    int value;
    Node left;
    Node right;

    public Node(int value) {
        this.value = value;
        this.left = null;
        this.right = null;
    }

    public static void preOrder(Node root) {
        if (root == null) {
            return;
        }

        System.out.print(root.value + "-");
        preOrder(root.left);
        preOrder(root.right);
    }
}

public class TreeMaxDepth {
    public static void main(String[] args) {
        Node root = new Node(3);

        root.left = new Node(9);
        root.right = new Node(20);

        root.right.left = new Node(15);
        root.right.right = new Node(7);

        System.out.println("max-depth  of the tree:");
        System.out.println(maxDepth(root));
        System.out.println("pendent vertex");
        System.out.println(countLeafNodes(root));
         System.out.println("Leaf node ");
         List<Integer> leaves = new ArrayList<>();
        getLeaves(root,leaves);
        System.out.println("Leaf nodes :"+leaves);

    }

    public static int maxDepth(Node root) {
        if (root == null) {
            return 0;
        }

        int leftDepth = maxDepth(root.left);
        int rightDepth = maxDepth(root.right);
       

        return Math.max(leftDepth, rightDepth) + 1;
    }

    public static int countLeafNodes(Node root) {
        if (root == null) {
            return 0;
        }

        if (root.left == null && root.right == null) {
            return 1;
        }

        return countLeafNodes(root.left) + countLeafNodes(root.right);
    }

    // Collects leaf node values in the given list
    static void getLeaves(Node root, List<Integer> leaves) {
        if (root == null) return;
        if (root.left == null && root.right == null) {
            leaves.add(root.value);
            return;
        }
        getLeaves(root.left, leaves);
        getLeaves(root.right, leaves);
    }
}
