using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class ScriptEstatico : MonoBehaviour
{
    public static ScriptEstatico instancia;
    public int[,] matriz;

    void Awake()
    {
        if (instancia == null)
        {
            DontDestroyOnLoad(gameObject);
            instancia = this;
        }
        else if (instancia != this)
        {
            Destroy(gameObject);
        }

    }

    public void Guardar()
    {
        try
        {
            string nombreFichero = "PartidGuardada";
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formateador = new BinaryFormatter();
            System.IO.FileStream fichero = File.Create(Application.persistentDataPath + "/" + nombreFichero + ".dat");

            ObjetoConMatriz datos = new ObjetoConMatriz();
            datos.matrizSerializada = this.matriz;

            
            formateador.Serialize(fichero, datos);
            fichero.Close();

        }
        catch (Exception e)
        {
            print("error: " + e);
        }
    }

    public void Cargar()
    {
        string nombreFichero = "PartidGuardada";
        if (File.Exists(Application.persistentDataPath + "/" + nombreFichero + ".dat"))
        {
            BinaryFormatter formateador = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/" + nombreFichero + ".dat", FileMode.Open);
            ObjetoConMatriz data = (ObjetoConMatriz)formateador.Deserialize(file);
            file.Close();
            this.matriz = data.matrizSerializada;
        }
        else
        {
            print("El fichero no existe");
        }
    }
}

[Serializable]
class ObjetoConMatriz
{
    public int[,] matrizSerializada;
}
