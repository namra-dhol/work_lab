import java.util.*;

public class DominatingSet {

    static Set<Integer> allVertices = new HashSet<>();
    static Map<Integer, Set<Integer>> adjacencyMap = new HashMap<>();

    public static void main(String[] args) {
        // Define edges
        int[][] edges = {{1, 2}, {1, 3}, {3, 4}, {2, 4}};

        // Build graph
        for (int[] edge : edges) {
            int u = edge[0], v = edge[1];
            allVertices.add(u);
            allVertices.add(v);

            adjacencyMap.putIfAbsent(u, new HashSet<>());
            adjacencyMap.putIfAbsent(v, new HashSet<>());
            adjacencyMap.get(u).add(v);
            adjacencyMap.get(v).add(u);
        }

        List<Integer> nodes = new ArrayList<>(allVertices);
        int n = nodes.size();
        int totalDominatingSets = 0;

        System.out.println("Dominating sets:");

        // Generate all subsets
        for (int mask = 1; mask < (1 << n); mask++) {
            Set<Integer> subset = new HashSet<>();
            for (int i = 0; i < n; i++) {
                if ((mask & (1 << i)) != 0) {
                    subset.add(nodes.get(i));
                }
            }

            if (isDominatingSet(subset)) {
                totalDominatingSets++;
                System.out.println(subset);
            }
        }

        System.out.println("Total number of dominating sets: " + totalDominatingSets);
    }

    static boolean isDominatingSet(Set<Integer> subset) {
        Set<Integer> covered = new HashSet<>(subset);
        for (int node : subset) {
            covered.addAll(adjacencyMap.getOrDefault(node, new HashSet<>()));
        }
        return covered.containsAll(allVertices);
    }
}
