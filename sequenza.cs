using System;
using System.Collections.Generic;
using System.Linq;

public static class Sequenza
{
    public static int[] Verifica( int N ) 
    {
        int length = 0; 
        for (int i = 0; i < N; i++) length += i + 1;
        int[] vet = new int[length];

        int dest = 0;
        int j = 0;
        for (int i = 1; i <= N; i++){
            for (; j <= dest; j++){
                vet[j] = i;
            }
            dest = j + i;
        }
        return vet;
    }
}