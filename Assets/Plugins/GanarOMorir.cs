using UnityEngine;
using UnityEngine.SceneManagement;

public class GanarOMorir : MonoBehaviour
{
    public float tiempoLimite = 180f; // Tiempo límite en segundos
    private bool gameOver = false; // Estado del juego
    private bool playerWin = false; // Estado del jugador

    private void Start()
    {
        // Inicia el contador de tiempo
        Invoke("GameOver", tiempoLimite);
    }

    // Si el collider del jugador toca el collider de salida, el jugador gana
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            PlayerWins();
        }
    }

    // Función para Game Over
    private void GameOver()
    {
        if (!playerWin)
        {
            gameOver = true;
            SceneManager.LoadScene("GameOverScene");
        }
    }

    // Función para que el jugador gane
    private void PlayerWins()
    {
        if (!gameOver)
        {
            playerWin = true;
            SceneManager.LoadScene("YouWin");
        }
    }
}
