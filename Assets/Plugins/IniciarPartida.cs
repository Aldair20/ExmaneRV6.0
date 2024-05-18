using UnityEngine;
using TMPro;

public class AparecerDesaparecerTexto : MonoBehaviour
{
    public float tiempoAparecer = 1f; // Tiempo en segundos para que el texto aparezca
    public float tiempoDesaparecer = 1f; // Tiempo en segundos para que el texto desaparezca

    private TextMeshProUGUI texto;

    void Start()
    {
        // Obtener el componente TextMeshProUGUI del GameObject
        texto = GetComponent<TextMeshProUGUI>();

        // Llamar a los métodos para que el texto aparezca y desaparezca
        Invoke("AparecerTexto", 0f);
        Invoke("DesaparecerTexto", tiempoAparecer);
    }

    void AparecerTexto()
    {
        // Mostrar el texto
        texto.enabled = true;
    }

    void DesaparecerTexto()
    {
        // Ocultar el texto
        texto.enabled = false;
    }
}
