using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptVista : MonoBehaviour
{

    private int[,] matriz;

    void Update()
    {
        //Con C Creamos una matriz nueva.
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("Creo una matriz");
            matriz = Utilidades.CrearMatrizNueva();
        }

        //Con P mostramos la ultima matriz creada o cargada.
        if (Input.GetKeyDown(KeyCode.P))
        {
            Utilidades.MostrarMatriz(matriz);
        }

        //Con S guardamos la ultima matriz creada.
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("Guardo la matriz");
            ScriptEstatico.instancia.matriz = matriz;
            ScriptEstatico.instancia.Guardar();
        }

        //Con L cargamos la ultima matriz guardada.
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("Cargo la matriz guardada");
            ScriptEstatico.instancia.Cargar();
            matriz = ScriptEstatico.instancia.matriz;
        }


    }
}
