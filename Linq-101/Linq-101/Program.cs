using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class AverageDistance
{
    public static void Main(String[] args)
    {
        string[] firstLine = Console.ReadLine().Split();
        int numClearing = int.Parse(firstLine[0]);
        int dest = numClearing - 1;
        int currentClearing = 0;

        List<List<int>> adj = new List<List<int>>(numClearing);

        for (int i = 0; i < numClearing; i++)
        {
            adj.Add(new List<int>());
        }

        int numEdges = int.Parse(firstLine[1]);

        for (int i = 0; i < numEdges; i++)
        {
            string[] edgeInput = Console.ReadLine().Split();
            int from = int.Parse(edgeInput[0]);
            int to = int.Parse(edgeInput[1]);
            addEdge(adj, from, to);
        }

        printAllPathsToDestination(adj, currentClearing, dest, numClearing);
    }

    private static void addEdge(List<List<int>> adj, int i, int j)
    {
        adj[i].Add(j);
        adj[j].Add(i);
    }

    private static void printAllPathsToDestination(List<List<int>> adj, int currentClearing, int dest, int numClearing)
    {
        List<int> path = new List<int>();
        bool[] visited = new bool[numClearing];
        int totalDistance = 0;
        List<int> totalDistancePath = new List<int>();
        printAllPathsToDestinationUtil(adj, currentClearing, dest, visited, path, ref totalDistance, ref totalDistancePath);
        double averageDistance = totalDistance * 2/adj.Count();
        string result = averageDistance.ToString("F6", CultureInfo.InvariantCulture);
        Console.WriteLine(result);
    }

    private static void printAllPathsToDestinationUtil(List<List<int>> adj, int currentClearing, int dest, bool[] visited, List<int> path, ref int totalDistance, ref List<int> totalDistancePath)
    {
        visited[currentClearing] = true;
        path.Add(currentClearing);

        if (currentClearing == dest)
        {
            int distance = path.Sum();
            if (distance > totalDistance)
            {
                totalDistance = distance;
                totalDistancePath = new List<int>(path);
            }
        }
        else
        {
            foreach (var neighbor in adj[currentClearing])
            {
                if (!visited[neighbor])
                {
                    printAllPathsToDestinationUtil(adj, neighbor, dest, visited, path, ref totalDistance, ref totalDistancePath);
                }
            }
        }

        visited[currentClearing] = false;
        path.Remove(currentClearing);
    }
}
