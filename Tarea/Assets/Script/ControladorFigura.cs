using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class ControladorFigura 
{
    [SerializeField]
    private GameObject contenedorFigura;
    [SerializeField]
    private Button boton;
    
    private void MostrarPanel()
    {
        contenedorFigura.SetActive(true);
    }

    public void Init(Action<float> callback)
    {
        boton.onClick.AddListener(() => MostrarPanel());
        contenedorFigura.GetComponent<Figura>().RegresarDato(callback);
    }

}
