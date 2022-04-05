using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    public int horas;
    // Start is called before the first frame update
    void Start()
    {
        int menosCuarenta = 16;
        int masCuarenta = 20;
        int dinero;

        if (horas <= 40)
        {
            Debug.Log("En esta semana, usted ganó $"+horas*menosCuarenta);
        }

        else
        {
            dinero = 40 * menosCuarenta + (horas - 40) * masCuarenta; 
            Debug.Log("En esta semana, usted ganó $"+ dinero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
