using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Transform startPoint;        // Punto de inicio
    public Transform endPoint;          // Punto de llegada
    public float speed = 5f;            // Velocidad de movimiento del objeto
    public float respawnTime = 2f;      // Tiempo de espera antes de respawnear
    public float respawnRandomRange = 1f; // Rango aleatorio para el tiempo de espera

    private bool isMoving = true;       // Indica si el objeto se está moviendo hacia el punto de llegada

    void Start()
    {
        transform.position = startPoint.position;    // Establecer la posición inicial del objeto
    }

    void Update()
    {
        if (isMoving)
        {
            float step = speed * Time.deltaTime;    // Calcular la distancia que el objeto se moverá en este frame

            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, step);    // Mover el objeto hacia el punto de llegada

            if (transform.position == endPoint.position)    // Si el objeto llega al punto de llegada
            {
                isMoving = false;    // Indicar que el objeto ha llegado a su destino y dejar de moverlo

                // Esperar un tiempo aleatorio antes de respawnear
                float respawnDelay = respawnTime + Random.Range(-respawnRandomRange, respawnRandomRange);
                Invoke("RespawnObject", respawnDelay);
            }
        }
    }

    void RespawnObject()
    {
        isMoving = true;    // Indicar que el objeto se está moviendo de nuevo

        transform.position = startPoint.position;    // Mover el objeto al punto de inicio

        // Reiniciar el tiempo aleatorio de espera antes de respawnear
        respawnTime = respawnTime + Random.Range(-respawnRandomRange, respawnRandomRange);
    }
}
