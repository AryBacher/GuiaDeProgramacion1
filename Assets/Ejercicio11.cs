using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public string fechaCompra = "Fecha de Compra";
    public string nombre = "Nombre";
    public string nombreProducto = "Nombre del Producto";
    public string cantTXT = "Ingrese la Cantidad de Productos Comprados";
    public int cantidad;
    public string preTXT = "Ingrese el Precio del Producto Comprado";
    public int precio;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fecha de Compra : "+fechaCompra);
        Debug.Log("Nombre del Comprador : " + nombre);
        Debug.Log("Producto Solicitado : " + nombreProducto);
        Debug.Log("Cantidad Solicitada : " + cantidad);
        Debug.Log("Precio Unitario : $" + precio);
        Debug.Log("Total a pagar : $" + cantidad*precio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
