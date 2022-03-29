using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    public string per1;
    public int num1;
    public string per2;
    public int num2;
    public string per3;
    public int num3;

    // Start is called before the first frame update
    void Start()
    {
        float monto = num1 + num2 + num3;
        float porc1 = (num1 / monto) * 100;
        float porc2 = (num2 / monto) * 100;
        float porc3 = (num3 / monto) * 100;
        Debug.Log("Nombre: "+per1+". Capital Aportado: $"+num1+ ". Porcentaje Del Capital: "+porc1+"%. Monto Total Aportado: $"+monto);
        Debug.Log("Nombre: " + per2 + ". Capital Aportado: $" + num2 + ". Porcentaje Del Capital: " + porc2 + "%. Monto Total Aportado: $" + monto);
        Debug.Log("Nombre: " + per3 + ". Capital Aportado: $" + num3 + ". Porcentaje Del Capital: " + porc3 + "%. Monto Total Aportado: $" + monto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
