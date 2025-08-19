#include <stdio.h>
#include <stdlib.h>
#include <time.h>


#define MAX 10000

int readfile(const char *filename, int arr[], int n) {
    FILE *f = fopen(filename, "r");
    if (!f) {
        printf("Cannot open the file %s\n", filename);
        return 0;
    }

    for (int i = 0; i < n; i++) {
        fscanf(f, "%d", &arr[i]);
    }
    fclose(f);
    return 1;
}


int merge(int u, int mid, int v, int array[]){
    int i = u;
    int j = mid + 1;
    int k = 0;
    int temp[v - u + 1];
    while (i <= mid && j <= v) {
        if (array[i] < array[j]) {
            temp[k++] = array[i++];
        } else {
            temp[k++] = array[j++];
        }
    }

    while (i <= mid) {
        temp[k++] = array[i++];
    }


    while (j <= v) {
        temp[k++] = array[j++];
    }

    for (i = u, k = 0; i <= v; i++, k++) {
        array[i] = temp[k];
    }


    return 0;
}
int mergesort(int u, int v,int array[]){
    if (u < v) {
        int mid = (u + v) / 2;
        mergesort(u, mid, array);
        mergesort(mid + 1, v, array);
        merge(u, mid, v, array);
    }
    return 0;
}
int main() {
    int arr[MAX];
    int n;
    clock_t start, end;
    double ans[3][3];  
    
    // [100,1000,10000] x [best,avg,worst]

    // ------------------- 100 elements -------------------

    n = 100;
    if (readfile("./Arrays/best_case_100.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[0][0] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    if (readfile("./Arrays/Avg_case_100.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[0][1] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    if (readfile("./Arrays/Worst_case_100.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[0][2] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    // ------------------- 1000 elements -------------------
    n = 1000;
    if (readfile("./Arrays/best_case_1000.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[1][0] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    if (readfile("./Arrays/Avg_case_1000.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[1][1] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    if (readfile("./Arrays/Worst_case_1000.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[1][2] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    // ------------------- 10000 elements -------------------
    n = 10000;
    if (readfile("./Arrays/best_case_10000.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[2][0] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    if (readfile("./Arrays/Avg_case_10000.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[2][1] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    if (readfile("./Arrays/Worst_case_10000.txt", arr, n)) {
        start = clock();
        mergesort(0, n, arr);
        end = clock();
        ans[2][2] = ((double)(end - start)) / CLOCKS_PER_SEC * 1000;
    }

    // --------------- Print Final Table --------------------
    printf("\n\nTime Taken by Merge Sort (in milliseconds):\n");
    printf("--------------------------------------------------------\n");
    printf("Elements\tBest Case\tAvg Case\tWorst Case\n");
    printf("--------------------------------------------------------\n");
    printf("100\t\t%.3f\t\t%.3f\t\t%.3f\n", ans[0][0], ans[0][1], ans[0][2]);
    printf("1000\t\t%.3f\t\t%.3f\t\t%.3f\n", ans[1][0], ans[1][1], ans[1][2]);
    printf("10000\t\t%.3f\t\t%.3f\t\t%.3f\n", ans[2][0], ans[2][1], ans[2][2]);
    printf("--------------------------------------------------------\n");

    return 0;
}