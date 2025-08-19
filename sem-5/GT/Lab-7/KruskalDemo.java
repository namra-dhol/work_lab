import java.util.*;
public class KruskalDemo {
    public static void main(String[] args) {
        int V = 7;
        int[][] a = {
                {1, 2, 4},
                {1, 4, 1},
                {2, 3, 12},
                {4, 5, 10},
                {4, 2, 7},
                {5, 6, 5},
                {2, 6, 14},
                {6, 3, 3}
        };

        Arrays.sort(a, (x, y) -> x[2] - y[2]);

        boolean[] visited = new boolean[V];
        int totalWeight = 0;

        System.out.println("Edges:");
        for (int[] edge : a) {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];

            if (visited[u] && visited[v]) continue;

            System.out.println(u + " -- " + v + " == " + w);
            totalWeight += w;

            visited[u] = true;
            visited[v] = true;
        }

        System.out.println("Total weight of MST: " + totalWeight);
    }
}


