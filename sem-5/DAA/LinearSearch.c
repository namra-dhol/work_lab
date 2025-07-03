#include<stdio.h>
#include<stdlib.h>
#include<time.h>
#define Max 100

int readArrayFormatFile(const char *filename,int arr[],int n){
    FILE *f =fopen(filename,"r");
    if(!f){
        printf("cna not open the file %s\n",filename);
        return 0;
    }
    for(int i=0;i<n;i++){
        // printf("arr is %d",arr[i]);
        fscanf(f,"%d",&arr[i]);
    }
    fclose(f);
    return 1;
}

int linearSearch(int arr[],int n,int find){
    for(int i=0;i<n;i++){
        if(arr[i]==find){
            printf(" index is %d",i);
            return i;
        }
    }
    return 0;
}

int binarySearch(int arr[],int n,int find){
    int min=0;
    int mid;
    int max=n - 1;
    while(min<=max){
        mid= (max+min)/2;

        if(find==arr[mid]) 
        {
             printf("%d %d",arr[mid],mid);
            return mid;
        }
        else if(find<arr[mid]){
            max = mid - 1;
        }
        else if(find>arr[mid]){
            min = mid + 1;
        }
    }
    return -1;
}

int main(){
    int arr[Max];
    clock_t start, end;
    double time_taken;
    if (readArrayFormatFile("D:/work_lab/sem-5/DAA/Arrays/best_case_100.txt", arr, Max))
    {
        start = clock();
        // linearSearch(arr, Max,25);
        binarySearch(arr,100,30);
        end = clock();
        time_taken = ((double)(end - start) / CLOCKS_PER_SEC);
        printf("best time case is %lf", time_taken);
    }
    return 0;
        
}