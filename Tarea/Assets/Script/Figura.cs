using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Figura : MonoBehaviour
{
    protected Button boton;

    private Action<float> regresar;
    private void Start()
    {
        boton.onClick.AddListener(() => regresar?.Invoke(CalcularArea()));
    }

    public void RegresarDato(Action<float> regresar)
    {
        this.regresar = regresar;
    }
    public abstract float CalcularArea();
}
