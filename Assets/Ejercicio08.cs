using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio08 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        if (dia <= 0 || dia > 7)
        {
            Debug.Log("El día ingresado no es válido");
        }

        else
        {
            switch (dia)
            {
                case 1:
                    Debug.Log("Domingo");
                    break;
                case 2:
                    Debug.Log("Lunes");
                    break;
                case 3:
                    Debug.Log("Martes");
                    break;
                case 4:
                    Debug.Log("Miércoles");
                    break;
                case 5:
                    Debug.Log("Jueves");
                    break;
                case 6:
                    Debug.Log("Viernes");
                    break;
                case 7:
                    Debug.Log("Sábado");
                    break;

            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
