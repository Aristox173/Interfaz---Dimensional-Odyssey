using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Regresar : MonoBehaviour
{
    public AudioClip clickSound;  // Asigna el clip de sonido en el Editor de Unity
    public Button[] otherButtons;  // Asigna los otros botones en el Editor de Unity
    public RawImage rawImage;
    public Slider slider;
    public Button newButton;

    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();

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

        // Desactiva otros botones
        foreach (Button otherButton in otherButtons)
        {
            if (otherButton != null)
            {
                otherButton.gameObject.SetActive(true);
            }
        }

        // Activa los nuevos elementos
        if (rawImage != null)
        {
            rawImage.gameObject.SetActive(false);
        }

        if (slider != null)
        {
            slider.gameObject.SetActive(false);
        }

        if (newButton != null)
        {
            newButton.gameObject.SetActive(false);
        }
    }
}
