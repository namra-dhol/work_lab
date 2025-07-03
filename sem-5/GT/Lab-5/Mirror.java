class Node {
    int value;
    Node left, right;

    public Node(int value) {
        this.value = value;
        this.left = this.right = null;
    }
}

public class Mirror {
    public static void main(String[] args) {
        // Build symmetric tree
        Node root = new Node(1);
        root.left = new Node(3);
        root.right = new Node(2);
        root.left.left = new Node(3);
        root.left.right = new Node(4);
        root.right.left = new Node(4);
        root.right.right = new Node(3); // Changed from 4 to 3 for symmetry

        boolean result = isSymmetric(root);
        System.out.println("Is tree symmetric? " + result);
    }

    // Function to check if the tree is symmetric
    public static boolean isSymmetric(Node root) {
        if (root == null) {
            return true;
        }
        return isMirror(root.left, root.right);
    }

    // Helper function to check mirror structure and values
    public static boolean isMirror(Node n1, Node n2) {
        if (n1 == null && n2 == null) {
            return true;
        }
        if (n1 == null || n2 == null) {
            return false;
        }
        return (n1.value == n2.value)
                && isMirror(n1.left, n2.right)
                && isMirror(n1.right, n2.left);
    }
}
