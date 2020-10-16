using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilidades : MonoBehaviour
{
    public static int[,] CrearMatrizNueva()
    {
        int tamaño = Random.Range(2, 10);
        int[,] matriz = new int[tamaño, tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            for (int j = 0; j < tamaño; j++)
            {
                matriz[i, j] = Random.Range(0, 100);
            }
        }
        return matriz;
    }

    public static void MostrarMatriz(int[,] matriz)
    {
        string cadena = "";
        int tamaño = matriz.GetLength(0);
        for (int i = 0; i < tamaño; i++)
        {
            for (int j = 0; j < tamaño; j++)
            {
                cadena += matriz[i, j] + " ";
            }
            cadena += "\n";
        }
        print(cadena);
    }
}
