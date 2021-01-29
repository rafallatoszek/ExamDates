using System;
using System.Collections.Generic;

namespace Interface
{
    public class Coloring
    {
        /* Sprawdza czy obecny kolor jest dostepny dla wierzcholka v */
        static bool IsAvailable(int vertex, int[,] graph, int[] color, int c)
        {
            for (int i = 0; i < vertex; i++)
                if (graph[vertex, i] == 1 && c == color[i])
                    return false;
            return true;
        }

        // funkcja bedaca algorytmem kolorowania
        static bool GraphColoringAlg(int[,] graph, int[] color, int vertex)
        {
            // jesli wszystkie wierzcholki maja kolor zwracamy true
            if (vertex == graph.GetLength(0))
                return true;

            // rozwazamy wierzcholek vertex i probujemy nowy kolor
            for (int c = 1; c <= graph.GetLength(0); c++)
            {
                // sprawdzamy czy mozliwe jest przypisanie do wierzcholka vertex koloru c
                if (IsAvailable(vertex, graph, color, c))
                {
                    color[vertex] = c; //przypisujemy kolor

                    // rekurencyjnie przypisujemy pozostale kolory do pozostalych wierzcholkow
                    if (GraphColoringAlg(graph, color, vertex + 1))
                        return true;

                    // jesli przypisanie koloru c nie prowadzi do rozwiazanie usuwamy go
                    color[vertex] = 0;

                    //jesli zaczynamy kolorowac od poczatku znaczy nie ma rozwiazania
                    if (color[0] == 0)
                        return false;
                }
            }
            // jesli zaden kolor nie moze byc przypisany do tego wierzcholka zwraca false
            return false;
        }

        /* Funkcja rozwiazuje algorytm "m Coloring". Uzywa do tego GraphColoringAlg(). Zaraca tablice przypisania kolorow do wierzcholkow. */
        public static int[] GraphColoring(int[,] graph)
        {
            int n = graph.GetLength(0); //ilosc egzaminow
            // Inicjalizujemy wszystkie kolory jako 0
            int[] color = new int[n];
            for (int i = 0; i < n; i++)
                color[i] = 0;

            // Wywolujemy graphColoringAlg() dla zerowego wierzcholka
            GraphColoringAlg(graph, color, 0);
            // Zwracamy tablice kolorow
            return color;
        }

        public static int[,] Connect(List<int> list, int[,] graph)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    graph[list[i], list[j]] = 1;
                    graph[list[j], list[i]] = 1;
                }
            }
            return graph;
        }
    }
}