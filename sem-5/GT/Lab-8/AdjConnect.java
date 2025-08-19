import java.util.*;

public class AdjConnect {
    public static void main(String[] args) {
        
        int[][] arr = {{1, 2}, {2, 3}, {4, 5}, {1, 5}};
        
      
        int v = 5; 
        
        
        int[][] adjMatrix = new int[v][v];

        for (int i = 0; i < arr.length; i++) {
            int from = arr[i][0] -1 ;
            int to = arr[i][1] -1 ;
            adjMatrix[from][to] = 1;
             adjMatrix[to][from] = 1;
        }

        System.out.println("Adjacency Matrix:");
        for (int i = 0; i < v; i++) {
            for (int j = 0; j < v; j++) {
                System.out.print(adjMatrix[i][j] + " ");
            }
            System.out.println();
        }

        // DFS to check connectivity
        boolean[] visited = new boolean[v];
        dfs(0, adjMatrix, visited, v);

        boolean isConnected = true;
        for (boolean vis : visited) {
            if (!vis) {
                isConnected = false;
                break;
            }
        }
        if (isConnected) {
            System.out.println("The graph is connected.");
        } else {
            System.out.println("The graph is not connected.");
        }
    }

    static void dfs(int node, int[][] adjMatrix, boolean[] visited, int v) {
        visited[node] = true;
        for (int i = 0; i < v; i++) {
            if (adjMatrix[node][i] == 1 && !visited[i]) {
                dfs(i, adjMatrix, visited, v);
            }
        }
    }
}
 