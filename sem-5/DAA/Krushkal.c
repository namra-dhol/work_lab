#include<stdio.h>

struct Edge
{
    int source;
    int dest;
    int weight;
};

void sortEdges(struct Edge edges[], int E){
    for(int i=0;i<E-1;i++){
        int minIndex = i;
        for(int j=i+1; j<E; j++){
            if(edges[j].weight < edges[minIndex].weight){
                minIndex = j;
            }
        }
        if(i != minIndex){
            struct Edge temp = edges[i];
            edges[i] = edges[minIndex];
            edges[minIndex] = temp;
        }
    }
}

int find(int parent[], int i){
    if( parent[i] == i) return i;
    return find(parent, parent[i]);
}

void unionSet (int parent[], int u, int v){
    parent[u] = v;
}

void kruskal(int V, int E, struct Edge edges[]){
    int parent[V];

    int edge = 0;
    struct Edge mst[V-1];

    for(int i=0; i<V; i++){
        parent[i] = i;
    }

    sortEdges(edges, E);

    for(int i=0; i<E; i++){
        int u = edges[i].source;
        int v = edges[i].dest;

        int ucomp = find(parent, u);
        int vcomp = find(parent, v);

        if(ucomp != vcomp){
            mst[edge] = edges[i];
            unionSet(parent,ucomp,vcomp);
            edge++;
        }

        if(edge == V-1) break;
    }

    int cost = 0;
    // Total Cost
    printf("Source :: Destination :: Weight \n");
    for(int i=0; i<V-1; i++){
        cost += mst[i].weight;
        printf("%d  %d  %d \n",mst[i].source,mst[i].dest,mst[i].weight);
    }

    printf("Total cost is = %d \n",cost);
}

void main(){
    int V = 4; // number of vertices
    int E = 5; // number of edges

    struct Edge edges[] = {
        {0, 1, 10},
        {0, 2, 6},
        {0, 3, 5},
        {1, 3, 15},
        {2, 3, 4}
    };

    kruskal(V, E, edges);
}