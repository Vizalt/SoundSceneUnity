using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 20f; // velocidad de rotación en grados por segundo

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update se llama una vez por fotograma
    void Update()
    {
        // Rota el objeto alrededor de su eje Y en la velocidad de rotación especificada
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}