import java.util.*;
public class ArrayDemo{
    public static void main(String[] s) {
        Scanner sc = new Scanner(System.in);
        System.out.println("enter Array size ");
        int n = sc.nextInt();
        int[] arr = new int[n];
        for(int i=0;i<n;i++){
            arr[i] = sc.nextInt();
        }

          for(int i=0;i<n;i++){
           System.out.print(" "+arr[i]);
        }

    }
}