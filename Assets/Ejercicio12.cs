using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;
    // Start is called before the first frame update
    void Start()
    {
        if (dado1 > 6 || dado1 < 1 || dado2 > 6 || dado2 < 1 || dado3 > 6 || dado3 < 1)
        {
            Debug.Log("Dado Ingresado Incorrecto");
        }

        else if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Excelente");
        }

        else if (dado1 == 6 && dado2 == 6 || dado1 == 6 && dado3 == 6 || dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Muy Bien");
        }

        else if (dado1 == 6 || dado2 == 6 || dado3 == 6)
        {
            Debug.Log("Regular");
        }

        else
        {
            Debug.Log("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
