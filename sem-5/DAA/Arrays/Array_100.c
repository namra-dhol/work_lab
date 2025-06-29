#include<stdio.h>
#include<stdlib.h>
#include<time.h>

#define N 100

void best_case_100(){
    FILE *f = fopen("best_case_100.txt","w");
    for(int i =1;i<=N;i++){
        fprintf(f,"%d ",i);
    }
    fclose(f);
}

void Worst_case_100(){
    FILE *f = fopen("Worst_case_100.txt","w");
    for(int i =N;i>0;i--){
        fprintf(f,"%d ",i);
    }
    fclose(f);
}

void Avg_case_100(){

    int arr[N];
    for(int i = 0;i<N;i++){
        arr[i] = i+1;
    }

    srand(time(NULL));
    for(int i= N-1;i>0;i--){
        int j = rand() % (i+1);
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    FILE *f = fopen("Avg_case_100.txt","w");
    for(int i=0;i<N;i++){
        fprintf(f,"%d ",arr[i]);
    }
    fclose(f);

  
}

  void main(){
        best_case_100();
        Worst_case_100();
        Avg_case_100();
    }
