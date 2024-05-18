using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
    public float tiempoLimite = 180f; // Tiempo límite en segundos
    public TMP_Text tiempoRestanteText; // Referencia al TextMeshPro para mostrar el tiempo restante
    private float tiempoRestante; // Tiempo restante

    private void Start()
    {
        tiempoRestante = tiempoLimite;
        ActualizarTextoTiempo();

        // Inicia el contador de tiempo
        InvokeRepeating("ActualizarTiempoRestante", 1f, 1f);
    }

    // Actualiza el tiempo restante y el texto
    private void ActualizarTiempoRestante()
    {
        tiempoRestante -= 1f;
        ActualizarTextoTiempo();
        if (tiempoRestante <= 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    // Actualiza el texto con el tiempo restante
    private void ActualizarTextoTiempo()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);
        tiempoRestanteText.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
