import java.util.*;

public class Matrix {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("enter the size of first array");
        int row = sc.nextInt();
        int col = sc.nextInt();
        int[][] a1 = new int[row][col];

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                a1[i][j] = sc.nextInt();
            }
        }

        System.out.println("enter the second element ");
        int[][] a2 = new int[row][col];
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                a2[i][j] = sc.nextInt();
            }
        }

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                System.out.println(a1[i][j]);
            }
        }

        System.out.println("addiction of matrix is ");
        int[][] add = new int[row][col];

        for (int i = 0; i < a1.length; i++) {
            for (int j = 0; j < a2.length; j++) {
                add[i][j] = a1[i][j] + a2[i][j];
            }
        }

        System.out.println("addiction is ");
        for (int i = 0; i < a1.length; i++) {
            for (int j = 0; j < a2.length; j++) {
                System.out.println(add[i][j]);
            }
        }

        
        System.out.println("tanspose is ");
        for (int i = 0; i < a1.length; i++) {
            for (int j = 0; j < a2.length; j++) {
                System.out.println(add[j][i]);
            }
        }
    }
}
