using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class SlenderMan : MonoBehaviour
{
    public Transform jugador; // Referencia al jugador
    public float velocidad = 2f; // Velocidad de Slender Man
    public float distanciaPersecucion = 10f; // Distancia máxima para comenzar a perseguir
    public float rangoColision = 1f; // Rango para colisión

    void Update()
    {
        // Calcular la distancia entre Slender Man y el jugador
        float distancia = Vector3.Distance(transform.position, jugador.position);

        // Si el jugador está dentro del rango de persecución
        if (distancia < distanciaPersecucion)
        {
            // Mover a Slender Man hacia el jugador
            Vector3 direccion = (jugador.position - transform.position).normalized;
            transform.position += direccion * velocidad * Time.deltaTime;

            // Verificar si Slender Man toca al jugador
            if (distancia < rangoColision)
            {
                PerderPartida(); // Llama al método para manejar la pérdida
            }
        }
    }

    // Método que se llama cuando el jugador pierde
    private void PerderPartida()
    {
        // Aquí puedes agregar la lógica que quieras para manejar la pérdida
        Debug.Log("¡Has sido atrapado por Slender Man! ¡Perdiste!");
        // Por ejemplo, podrías mostrar una pantalla de derrota, reiniciar el juego, etc.
    }
}

