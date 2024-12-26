using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInteraction : MonoBehaviour
{
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            points++;
            Debug.Log("Puntos: " + points);

            if (points >= 3)
            {
                Debug.Log("¡Juego terminado!");
            }

            // Reinicia la posición del objeto interactuable
            collision.gameObject.transform.position = new Vector3(
                Random.Range(-5, 5), 
                0.5f, 
                Random.Range(-5, 5)
            );
        }
    }
}
