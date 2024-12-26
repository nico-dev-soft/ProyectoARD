using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Obtener las cámaras disponibles
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length > 0)
        {
            // Crear una textura de la primera cámara disponible
            WebCamTexture webcamTexture = new WebCamTexture(devices[0].name, 320, 240, 10);
            MeshRenderer renderer = GetComponent<MeshRenderer>();

            if (renderer != null) // Verifica que el Mesh Renderer existe
            {
                renderer.material.mainTexture = webcamTexture; // Asignar la textura al material
                webcamTexture.Play(); // Inicia la cámara
            }
            else
            {
                Debug.LogError("No se encontró un Mesh Renderer en este objeto.");
            }
        }
        else
        {
            Debug.LogError("No se encontró ninguna cámara disponible.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
