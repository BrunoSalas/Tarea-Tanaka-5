using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Circulo : Figura
{
    [SerializeField]
    private TMP_InputField circuloREntrada;

    public override float CalcularArea()
    {

        float r = float.Parse(circuloREntrada.text);
        return (r*r)*3.14f;

    }
}
