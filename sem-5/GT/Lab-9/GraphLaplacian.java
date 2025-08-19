import java.util.*;

public class GraphLaplacian {

    private int[][] adjacencyMatrix;
    private int[][] degreeMatrix;
    private int[][] laplacianMatrix;
    private int numVertices;

    public GraphLaplacian(int numVertices) {
        this.numVertices = numVertices;
        adjacencyMatrix = new int[numVertices][numVertices];
    }

    // Add undirected edge
    public void addEdge(int u, int v) {
        if (u >= 0 && v >= 0 && u < numVertices && v < numVertices) {
            adjacencyMatrix[u][v] = 1;
            adjacencyMatrix[v][u] = 1;
        }
    }

    public void computeMatrices() {
        degreeMatrix = new int[numVertices][numVertices];
        laplacianMatrix = new int[numVertices][numVertices];

        for (int i = 0; i < numVertices; i++) {
            int degree = 0;
            for (int j = 0; j < numVertices; j++) {
                if (adjacencyMatrix[i][j] == 1) {
                    degree++;
                }
            }
            degreeMatrix[i][i] = degree;
        }

        // L = D - A
        for (int i = 0; i < numVertices; i++) {
            for (int j = 0; j < numVertices; j++) {
                laplacianMatrix[i][j] = degreeMatrix[i][j] - adjacencyMatrix[i][j];
            }
        }
    }

    public void printMatrix(int[][] matrix, String name) {
        System.out.println(name + ":");
        for (int[] row : matrix) {
            System.out.println(Arrays.toString(row));
        }
        System.out.println();
    }

    public static void main(String[] args) {
        GraphLaplacian graph = new GraphLaplacian(4); // 4 nodes: 0,1,2,3

        // Sample edges
        graph.addEdge(0, 1);
        graph.addEdge(0, 2);
        graph.addEdge(1, 2);
        graph.addEdge(2, 3);

        graph.computeMatrices();

        graph.printMatrix(graph.adjacencyMatrix, "Adjacency Matrix");
        graph.printMatrix(graph.degreeMatrix, "Degree Matrix");
        graph.printMatrix(graph.laplacianMatrix, "Laplacian Matrix");
    }
}