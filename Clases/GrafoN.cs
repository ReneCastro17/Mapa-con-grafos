using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio2GRAFOS;


namespace Ejercicio2GRAFOS
{
    public class GrafoN
    {
        public static int Dijkstra(Dictionary<int, List<(int, int)>> graph, int source, int destination)
        {
            //Algoritmo dijkstra se encarga que devolver la ruta mas corta
            //Este algoritmo recorre todos los caminos posible de un nodo origen a un nodo destino y guarda cada valor
            //Devuelve el menos valor como camino mas corto
            int n = graph.Count;

            int[] distance = new int[n];
            bool[] visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                distance[i] = int.MaxValue;
                visited[i] = false;
            }

            distance[source] = 0;

            for (int count = 0; count < n - 1; count++)
            {
                int u = MinimumDistance(distance, visited);
                visited[u] = true;

                foreach ((int v, int weight) in graph[u])
                {
                    if (!visited[v] && distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                    {
                        distance[v] = distance[u] + weight;
                    }
                }
            }

            return distance[destination];
        }

        static int MinimumDistance(int[] distance, bool[] visited)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < distance.Length; i++)
            {
                if (!visited[i] && distance[i] <= min)
                {
                    min = distance[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

    }
}
