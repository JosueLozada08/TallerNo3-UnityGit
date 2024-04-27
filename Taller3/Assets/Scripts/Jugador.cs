using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector3 escalaInicial = new Vector3(1, 1, 1);
    private float incrementoEscala = 0.1f;

    private float minX = -4.5f;
    private float maxX = 4.5f;
    private float minZ = -4.5f;
    private float maxZ = 4.5f;

    public Enemigo enemigoScript; // Referencia al script del enemigo

    private void Start()
    {
        if (enemigoScript == null)
        {
            Debug.LogError("La referencia al enemigo no está configurada en el Inspector.");
        }
    }

    private void Update()
    {
        transform.Rotate(new Vector3(2, 2, 2));

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        Vector3 nuevaPosicion = transform.position + (movimiento * velocidad * Time.deltaTime);

        nuevaPosicion.x = Mathf.Clamp(nuevaPosicion.x, minX, maxX);
        nuevaPosicion.z = Mathf.Clamp(nuevaPosicion.z, minZ, maxZ);
        transform.position = nuevaPosicion;

        // Verificar si se ha presionado la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Cambiar el color del enemigo
            enemigoScript.ChangeColor();
        }
    }
}
