import java.util.*;

public class KruskalDemo {

    static class Edge {
        int u, v, weight;
        Edge(int u, int v, int w) {
            this.u = u;
            this.v = v;
            this.weight = w;
        }
    }

    static class DSU {
        int[] parent;

        DSU(int n) {
            parent = new int[n];
            for (int i = 0; i < n; i++) parent[i] = i;
        }

        int find(int x) {
            if (parent[x] != x)
                parent[x] = find(parent[x]); // Path compression
            return parent[x];
        }

        void union(int x, int y) {
            int px = find(x);
            int py = find(y);
            if (px != py)
                parent[py] = px;
        }
    }

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

        List<Edge> edges = new ArrayList<>();
        for (int[] e : a)
            edges.add(new Edge(e[0], e[1], e[2]));

        // Sort edges by weight
        edges.sort(Comparator.comparingInt(e -> e.weight));

        DSU dsu = new DSU(V);
        int totalWeight = 0;

        System.out.println("Edges in MST:");
        for (Edge edge : edges) {
            if (dsu.find(edge.u) != dsu.find(edge.v)) {
                dsu.union(edge.u, edge.v);
                System.out.println(edge.u + " -- " + edge.v + " == " + edge.weight);
                totalWeight += edge.weight;
            }
        }

        System.out.println("Total weight of MST: " + totalWeight);
    }
}
