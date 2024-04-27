using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private Renderer enemyRenderer;

    private void Start()
    {
        enemyRenderer = GetComponent<Renderer>();
        // No necesitamos la llamada a CambiarColorSucesivamente aquí
    }

    public void ChangeColor()
    {
        enemyRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
