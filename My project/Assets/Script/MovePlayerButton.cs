/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveGuideObject : MonoBehaviour
{
    public GameObject guideObject; // Referencia al objeto guía
    public Vector3 targetPosition = new Vector3(5f, 2f, 0f); // Posición a la que el objeto guía se moverá
    public float speed = 5.0f; // Velocidad de movimiento del objeto guía

    private bool isMoving = false;

    void Start()
    {
        // Obtener una referencia al botón
        Button moveButton = GetComponent<Button>();

        // Agregar un listener al botón para llamar al método MoveGuide() cuando se haga clic
        moveButton.onClick.AddListener(MoveGuide);
    }

    void Update()
    {
        // Si el guía está en movimiento, moverlo hacia la posición objetivo
        if (isMoving && guideObject != null)
        {
            float step = speed * Time.deltaTime;
            guideObject.transform.position = Vector3.MoveTowards(guideObject.transform.position, targetPosition, step);

            // Si el guía ha llegado a la posición objetivo, detener el movimiento
            if (guideObject.transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }

    void MoveGuide()
    {
        // Verificar si el objeto guía existe
        if (guideObject != null)
        {
            // Activar el movimiento del guía hacia la posición objetivo
            isMoving = true;
        }
    }
}

/*
public class MoveObjectsButton : MonoBehaviour
{
    public GameObject player; // Referencia al objeto jugador
    public GameObject mainCamera; // Referencia a la cámara principal
    public GameObject guideObject; // Referencia al objeto guía
    public Vector3 newPositionPlayer = new Vector3(5f, 2f, 0f); // Nueva posición para los objetos
    public Vector3 newPositionCamera = new Vector3(5f, 2f, 0f);
    public Vector3 newPositionGuia = new Vector3(5f, 2f, 0f);
    void Start()
    {
        // Obtener una referencia al botón
        Button moveButton = GetComponent<Button>();

        // Agregar un listener al botón para llamar al método MoveObjects() cuando se haga clic
        moveButton.onClick.AddListener(MoveObjects);
    }

    void MoveObjects()
    {
        // Verificar si los objetos existen y luego cambiar sus posiciones
        if (player != null)
        {
            // Cambiar la posición del jugador
            player.transform.position = newPositionPlayer;
        }

        if (mainCamera != null)
        {
            // Cambiar la posición de la cámara
            mainCamera.transform.position = newPositionCamera; // Mover la cámara un poco hacia atrás en Z
        }

        if (guideObject != null)
        {
            // Cambiar la posición del objeto guía
            guideObject.transform.position = newPositionGuia; // Mover el objeto guía un poco hacia la izquierda en X
        }
    }
}*/