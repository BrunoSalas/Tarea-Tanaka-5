using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cuadrado : Figura
{
    [SerializeField]
    private TMP_InputField cuadradoLEntrada;

    public override float CalcularArea()
    {

        float l = float.Parse(cuadradoLEntrada.text);
        return l * l;

    }
}
