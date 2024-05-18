using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToZombieLand : MonoBehaviour
{
    public float delayBeforeReturn = 0.5f; // Tiempo de espera antes de regresar a INICIO

    void Start()
    {
        // Llama a la función para regresar después de un retraso
        Invoke("ReturnToZombieLandScene", delayBeforeReturn);
    }

    void ReturnToZombieLandScene()
    {
        // Carga la escena "INICIO"
        SceneManager.LoadScene("INICIO");
    }
}
