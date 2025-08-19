#include <stdio.h>

#define V 8 

int graph[V][V];     
int visited[V];     
void DFS(int vertex) {
    visited[vertex] = 1;
    printf("Visited %d\n", vertex+1);

    for (int i = 0; i < V; i++) {
        if (graph[vertex][i] == 1 && !visited[i]) {
            DFS(i);
        }
    }
}

int main() {
    for (int i = 0; i < V; i++) {
        visited[i] = 0;
        for (int j = 0; j < V; j++) {
            graph[i][j] = 0;
        }
    }

    int edges[][2] = {
        {0, 1},
        {0, 2},
        {0, 3},
        {0, 4},
        {1, 5},
        {2, 5},
        {3, 6},
        {4, 6},
        {5, 7},
        {6, 7}
    };
    int edgeCount = sizeof(edges) / sizeof(edges[0]);

    for (int i = 0; i < edgeCount; i++) {
        int src = edges[i][0];
        int dest = edges[i][1];
        graph[src][dest] = 1;
        graph[dest][src] = 1;
    }

    printf("Depth First Search starting from vertex 1:\n");
    DFS(0);

    return 0;
}