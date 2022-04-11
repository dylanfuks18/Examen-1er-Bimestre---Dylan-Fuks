using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    public int moneda_extranjera;
   
    public int cantpesos_argentinos;
     

    void Start()
    {
         int D = 112;
         int R = 23;
         int E = 122;
    int dinerotraspaso;
        dinerotraspaso = (cantpesos_argentinos / 112|23|122);
        Debug.Log("El traspaso de pesos argentinos a su moneda es de: " + dinerotraspaso);

        if  (moneda_extranjera != D | moneda_extranjera!= R | moneda_extranjera != E)
        {
            Debug.Log(" Opción de moneda extranjera no válida”.");
        }
        else
        {

        } 

        if (dinerotraspaso < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
        }
        else
            Debug.Log(+ cantpesos_argentinos + "dinero ingresado, equivalen a " + dinerotraspaso);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
