using System;
using System.Collections.Generic;

namespace homework4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] Graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            DijkstraAlgorithm Dijkstra = new DijkstraAlgorithm();
            Dijkstra.DijkstraAlgo(Graph, 0);
        }
    }

    public class DijkstraAlgorithm
    {
        static int NumberOfVertices = 9;

        int MinDistance(int[] Dist, bool[] SptSet)
        {
            int Min = int.MaxValue, Min_index = -1;
            for (int n = 0; n < NumberOfVertices; n++)
            {
                if (SptSet[n] == false && Dist[n] <= Min)
                {   Min = Dist[n]; Min_index = n;   }
            }
            return Min_index;
        }

        void printPaths(int[] dist, int srcVert,int a)
        {
            Console.Write("Vertex Distance from Source {0}\n", srcVert);
            for (int i = 0; i < NumberOfVertices; i++)
            {   Console.Write(i + " \t\t " + dist[i] + "\n");   }
        }

        public void DijkstraAlgo(int[,] Graph, int srcVert)
        {
            int[] dist = new int[NumberOfVertices]; bool[] sptSet = new bool[NumberOfVertices];

            for (int i = 0; i < NumberOfVertices; i++)
            {   dist[i] = int.MaxValue; sptSet[i] = false;   }

            dist[srcVert] = 0;
            for (int count = 0; count < NumberOfVertices - 1; count++)
            {
                int minDistIndx = MinDistance(dist, sptSet);
                sptSet[minDistIndx] = true;
                for (int indx = 0; indx < NumberOfVertices; indx++)
                {
                    if (!sptSet[indx] && Graph[minDistIndx, indx] != 0 && dist[minDistIndx] != int.MaxValue && dist[minDistIndx] + Graph[minDistIndx, indx] < dist[indx])
                    {   dist[indx] = dist[minDistIndx] + Graph[minDistIndx, indx];   }
                }
            }
            printPaths(dist, NumberOfVertices, srcVert);
        }
    }
}




