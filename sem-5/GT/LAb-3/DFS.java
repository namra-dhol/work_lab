// Function to find BFS of Graph from given source s
import java.util.*;

class DFS{
   
    static ArrayList<Integer> bfs(ArrayList<ArrayList<Integer>> adj) {
        int V = adj.size();
        
        int s = 0; 
        
        ArrayList<Integer> res = new ArrayList<>();
        
        
        Queue<Integer> q = new LinkedList<>();
        
        
        boolean[] visited = new boolean[V];
        
        visited[s] = true;
        q.add(s);
        
        while (!q.isEmpty()) {           
            int curr = q.poll();
            res.add(curr);
            
            for (int x : adj.get(curr)) {
                if (!visited[x]) {
                    visited[x] = true;
                    q.add(x);
                }
            }
        }
        return res;
    }

    public static void dfs(Map<Integer, List<Integer>> graph, int start, Set<Integer> visited) {
      
        visited.add(start);
        System.out.print(start + " ");
    
       
        for (int neighbor : graph.getOrDefault(start, new ArrayList<>())) {
            if (!visited.contains(neighbor)) {
                dfs(graph, neighbor, visited);
            }
        }
    }
    
    public static void main(String[] args) {
        
        ArrayList<ArrayList<Integer>> adj = new ArrayList<>();
        adj.add(new ArrayList<>(Arrays.asList(1, 2)));
        adj.add(new ArrayList<>(Arrays.asList(0, 2, 3)));       
        adj.add(new ArrayList<>(Arrays.asList(0, 1, 4)));       
        adj.add(new ArrayList<>(Arrays.asList(1,4)));          
        adj.add(new ArrayList<>(Arrays.asList(2,3)));          
        
        
        ArrayList<Integer> ans = bfs(adj);
        for (int i : ans) {
            System.out.print(i + " ");
        }
        Map<Integer, List<Integer>> graph = new HashMap<>();
        
        
        graph.put(0, Arrays.asList(1, 2));
        graph.put(1, Arrays.asList(3, 4));
        graph.put(2, Arrays.asList());
        graph.put(3, Arrays.asList());
        graph.put(4, Arrays.asList());
        
        // Start DFS from node 0
        Set<Integer> visited = new HashSet<>();
        System.out.print("DFS traversal: ");
        dfs(graph, 0, visited);
    }
}