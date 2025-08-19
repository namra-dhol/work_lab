import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;

public class L10_1_FindDominatingSet {

    static public void DominatingSet(int[][] edges, int v, Set<Integer> set, ArrayList<Set<Integer>> dominatingSets) {

        ArrayList<Boolean> arr = new ArrayList<>();
        for (int i = 0; i < v; i++) {
            arr.add(false);
        }

        for (int x : set) {
            arr.set(x, true);
            for (int i = 0; i < edges.length; i++) {
                if (edges[i][0] == x) {
                    arr.set(edges[i][1], true);
                }
            }
        }
        if (!arr.contains(false)) {
            dominatingSets.add(set);
        }

    }

    public static void main(String[] args) {
        int n = 4;
        int[][] edges = {{1, 2}, {1, 3}, {3, 4}, {2, 4}};
        

        Set<Set<Integer>> listOfSets = new HashSet<>();

        // for (int i = 1; i < (1 << n); i++) {
        // Set<Integer> temp = new HashSet<>();
        // for (int j = 0; j < n; j++) {
        // if ((i & (1 << j)) != 0) {
        // temp.add(j);
        // }
        // }
        // listOfSets.add(temp);
        // }
        Set<Set<Integer>> allSubsets = new HashSet<>();
        for (int i = 0; i < n; i++) {
            // Single element
            Set<Integer> a = new HashSet<>();
            a.add(i+1);

            allSubsets.add(a);

            for (int j = i + 1; j < n; j++) {
                // Two elements
                Set<Integer> b = new HashSet<>();
                b.add(i);
                b.add(j);
                allSubsets.add(b);

                for (int k = j + 1; k < n; k++) {
                    // Three elements
                    Set<Integer> c = new HashSet<>();
                    c.add(i);
                    c.add(j);
                    c.add(k);
                    allSubsets.add(c);
                }
            }
        }

        Set<Integer> fullSet = new HashSet<>();
        for (int i = 0; i < n; i++) {
            fullSet.add(i);
        }
        allSubsets.add(fullSet);

        // Print all subsets
        for (Set<Integer> set : allSubsets) {
            System.out.println(set);
        }

        System.out.println("Total subsets: " + allSubsets.size());

        ArrayList<Set<Integer>> dominatingSets = new ArrayList<Set<Integer>>();

        for (Set<Integer> x : listOfSets) {
            DominatingSet(edges, n, x, dominatingSets);
        }

        int minSize = Integer.MAX_VALUE;
        for (Set<Integer> x : dominatingSets) {
            minSize = Math.min(minSize, x.size());
        }

        for (Set<Integer> x : dominatingSets) {
            if (x.size() == minSize) {
                System.out.println(x);
            }
        }

    }
}
