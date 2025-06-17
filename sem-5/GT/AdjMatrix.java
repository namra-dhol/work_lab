import java.util.*;

public class AdjMatrix {
    public static void main(String[] args) {
        
        int[][] arr = {{0, 1}, {0, 2}, {1, 2}, {2, 0}};
        
      
        int v = 4; 
        
        
        int[][] adjMatrix = new int[v][v];

        for (int i = 0; i < arr.length; i++) {
            int from = arr[i][0];
            int to = arr[i][1];
            adjMatrix[from][to] = 1;
        }

        System.out.println("Adjacency Matrix:");
        for (int i = 0; i < v; i++) {
            for (int j = 0; j < v; j++) {

                System.out.print(adjMatrix[i][j] + " ");
            }
            System.out.println();
        }
        System.out.println("print output ");
        for (int row = 0; row < 4; row++) {

            System.out.print(row + " : ");
            for (int col = 0; col < 4; col++) {
                if(adjMatrix[row][col] == 1){
                    System.out.print(col + ",");
                }              
            }
             System.out.println();
            
        }


    }
}
