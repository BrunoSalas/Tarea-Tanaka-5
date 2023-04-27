using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
[Serializable]
public class ControladorFigura 
{
    [SerializeField]
    private GameObject panelFigura;
    [SerializeField]
    private Button boton;
    
    private void MostrarPanel()
    {
        panelFigura.SetActive(true);
    }

    public void Init()
    {
        boton.onClick.AddListener(() => MostrarPanel());
    }

}
