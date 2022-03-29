using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio06 : MonoBehaviour
{
    public string txt = "Por favor ingrese un número mayor a 0";
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 <= 0)
        {
            Debug.Log("Ingrese un número menor a 0");
        }
        else
        {
            if (num1 % 2 == 0)
            {
                Debug.Log("Su número es par");
            }
            else
            {
                Debug.Log("Su número es impar");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
