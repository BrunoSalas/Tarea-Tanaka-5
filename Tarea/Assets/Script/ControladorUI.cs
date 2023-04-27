using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorUI : MonoBehaviour
{

    [SerializeField]
    private List <ControladorFigura> controladoresFiguras;

    [SerializeField]
    private TextMeshProUGUI textoResultado;


    void Start()
    {

        foreach (var figura in controladoresFiguras)
        {

            figura.Init(Resultado);

        }

    }

    private void Resultado(float resultado)
    {

        textoResultado.text = $"resultado:{resultado}";

    }
}
