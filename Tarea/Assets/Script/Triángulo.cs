using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Triángulo : Figura
{
    [SerializeField]
    private TMP_InputField triánguloBEntrada;
    [SerializeField]
    private TMP_InputField triánguloHEntrada;


    public override float CalcularArea()
    {
        float b = float.Parse(triánguloBEntrada.text);
        float h = float.Parse(triánguloHEntrada.text);

        return (b * h)/2;
    }

}
