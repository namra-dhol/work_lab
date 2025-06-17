import java.lang.reflect.Array;
import java.util.*;

public class JAdjMatrix {
    public static void main(String[] args) {
        int arr[][] = { { 0, 1 }, { 1, 2 }, { 1, 3 }, { 2, 0 } };
        HashMap<Integer, ArrayList<Integer>> map = new HashMap<>();
        // System.out.println(map.keySet());
        for (int i = 0; i < 4; i++) {
            map.putIfAbsent(arr[i][0], new ArrayList<Integer>());
            map.get(arr[i][0]).add(arr[i][1]);
        }
        System.out.println(map); 
    }
}