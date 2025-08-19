class DisjointSet {
    int[] parent, rank;

    DisjointSet(int n) {
        parent = new int[n];
        rank = new int[n];
        for(int i = 0; i < n; i++)
            parent[i] = i;
    }

    int find(int u) {
        if(parent[u] != u)
            parent[u] = find(parent[u]); // Path compression
        return parent[u];
    }

    boolean union(int u, int v) {
        int rootU = find(u);
        int rootV = find(v);
        if(rootU == rootV)
            return false;

        // Union by rank
        if(rank[rootU] < rank[rootV]) {
            parent[rootU] = rootV;
        } else if(rank[rootU] > rank[rootV]) {
            parent[rootV] = rootU;
        } else {
            parent[rootV] = rootU;
            rank[rootU]++;
        }
        return true;
    }
}

