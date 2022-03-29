using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio07 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Todos Los Números Son Iguales");
        }

        else if (num1 == num2 && num1 > num3)
        {
            Debug.Log("num1 y num2 son iguales");
        }

        else if (num1 == num3 && num1 > num2)
        {
            Debug.Log("num1 y num3 son iguales");
        }

        else if (num3 == num2 && num3 > num1)
        {
            Debug.Log("num3 y num2 son iguales");
        }

        else if (num1 > num2 && num1 > num3)
        {
            Debug.Log("El Mayor Número es "+num1);
        }

        else if (num2 > num1 && num2 > num3)
        {
            Debug.Log("El Mayor Número es " + num2);
        }

        else if (num3 > num2 && num3 > num1)
        {
            Debug.Log("El Mayor Número es " + num2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
