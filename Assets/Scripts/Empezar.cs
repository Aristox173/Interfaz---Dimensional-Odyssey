using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Empezar : MonoBehaviour
{
    public AudioClip clickSound;  // Asigna el clip de sonido en el Editor de Unity
    public float delayBeforeSceneChange = 2.0f;  // Ajusta el tiempo de retraso en segundos
    private Button button;

    private void Start()
    {
        // Asumiendo que este script está adjunto al mismo GameObject que el componente Button
        button = GetComponent<Button>();

        // Añade un listener para el evento de clic del botón
        if (button != null)
        {
            button.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogError("Componente Button no encontrado en el GameObject.");
        }
    }

    private void OnClick()
    {
        // Reproduce el sonido de clic
        if (clickSound != null)
        {
            AudioSource.PlayClipAtPoint(clickSound, Camera.main.transform.position);
        }

        // Invoca la carga de escena con un retraso
        Invoke("ChangeScene", delayBeforeSceneChange);
    }

    private void ChangeScene()
    {
        // Cambia la escena (puedes reemplazar "NombreDeTuEscena" con el nombre real de la escena)
        SceneManager.LoadScene("Level 1");
    }
}