import java.util.*;

public class GraphRankSimple {
    
    static void dfs(int node, boolean[] visited, int[][] graph) {
        visited[node] = true;
        for (int i = 0; i < graph.length; i++) {
            if (graph[node][i] == 1 && !visited[i]) {
                dfs(i, visited, graph);
            }
        }
    }

    public static void main(String[] args) {
        int[][] graph = {
            {1, 1, 0, 0},
            {1, 1, 0, 0},
            {0, 0, 1, 1},
            {0, 0, 1, 1}
        };

        int n = graph.length;  // vertex
        boolean[] visited = new boolean[n];
        int components = 0;

        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                components++;
                dfs(i, visited, graph);
            }
        }

        int rank = n - components;
        System.out.println("Rank of the graph is: " + rank);
    }
}
