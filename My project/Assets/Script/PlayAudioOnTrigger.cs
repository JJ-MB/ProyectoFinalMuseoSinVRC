using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class PlayAudioOnButton : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al componente AudioSource

    void Start()
    {
        // Obtener el componente Button del objeto
        Button yourButton = GetComponent<Button>();

        // Agregar un listener al botón para reproducir el audio
        yourButton.onClick.AddListener(PlayAudio);
    }

    void PlayAudio()
    {
        // Verificar si se asignó un AudioSource y si está habilitado para reproducir el audio
        if (audioSource != null && audioSource.enabled)
        {
            audioSource.Play();
        }
    }
}