using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    public string num;
    bool estaEnA = false;
    bool estaEnB = false;
    bool estaEnAmbos = false;
    bool noEstaEnNinguno = false;
    // Start is called before the first frame update
    void Start()
    {
        int num1;

        num1 = Convert.ToInt32(num);

        if (num.Length == 1)
        {
            estaEnA = true;
        }

        if (num1 % 2 == 1)
        {
            estaEnB = true;
        }

        if (estaEnA == true && estaEnB == true)
        {
            estaEnAmbos = true;
        }

        if (estaEnA == false && estaEnB == false)
        {
            noEstaEnNinguno = true;
        }

        if (estaEnA == true)
        {
            Debug.Log("Su número contiene un solo dígito");
        }

        else
        {
            Debug.Log("Su número contiene mas de un dígito");
        }

        if (estaEnB == true)
        {
            Debug.Log("Su número es Impar");
        }

        else
        {
            Debug.Log("Su número es Par");
        }

        if (estaEnAmbos == true)
        {
            Debug.Log("Su número contiene un dígito y es Impar");
        }

        if (noEstaEnNinguno == true)
        {
            Debug.Log("Su número contiene más de un dígito y es Par");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
