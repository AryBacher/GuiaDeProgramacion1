using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    public int hora;
    // Start is called before the first frame update
    void Start()
    {
        int Hora_Apertura = 10;
        int Hora_Cierre = 18;
        bool estaAbierto = false;

        if (hora > 24 || hora < 0)
        {
            Debug.Log("Ha ingresado una hora Incorrecta");
        }

        else if (hora > Hora_Apertura && hora < Hora_Cierre)
        {
            estaAbierto = true;
        }

        else
        {
            estaAbierto = false;
        }

        if (estaAbierto == true)
        {
            Debug.Log("El Estacionamiento se encuentra Abierto");
        }

        else if (hora <= 24 && hora >= 0)
        {
            Debug.Log("El Estacionamiento se encuentra Cerrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
