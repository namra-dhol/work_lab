#include <stdio.h>


int main()
{
    int v = 6;
    int arr[6][6] = {
      {0,9,22,0,11,12},
        {9,0,16,0,14,8},
        {22,16,0,15,18,0},
        {0,0,15,0,3,0},
        {11,14,18,3,0,0},
        {12,8,0,0,0,0}
    };
    int selected[v];
    int no_edge = v - 1;
    int x, y;
    int min;
    int cost = 0;
    for (int i = 0; i < v; i++)
        selected[i] = 0;
    selected[0] = 1;
    printf("Edge : Weight\n");
    while (no_edge > 0)
    {
        min = __INT_MAX__;
        x = 0;
        y = 0;
        for (int i = 0; i < v; i++)
        {
            if (selected[i])
            {
                for (int j = 0; j < v; j++)
                {
                    if (selected[j] == 0 && arr[i][j])
                    {
                        if (min > arr[i][j])
                        {
                            min = arr[i][j];
                            x = i;
                            y = j;
                        }
                    }
                }
            }
        }
        selected[y] = 1;
        printf("%d - %d : %d\n", x, y, min);
        cost += min;
        no_edge--;
        if (no_edge == 0)
        {
            printf("Total cost of the minimum spanning tree: %d\n", cost);
        }
    }
    return 0;
}