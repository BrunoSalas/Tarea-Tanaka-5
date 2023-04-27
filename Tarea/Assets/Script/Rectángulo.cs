using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Rectángulo : Figura
{
    [SerializeField]
    private TMP_InputField rectánguloBEntrada;
    [SerializeField]
    private TMP_InputField rectánguloHEntrada;


    public override float CalcularArea()
    {
        float b = float.Parse(rectánguloBEntrada.text);
        float h = float.Parse(rectánguloHEntrada.text);

        return b * h;
    }

}
