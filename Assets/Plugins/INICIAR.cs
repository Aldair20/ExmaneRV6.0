using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    void Update()
    {
        // Verificar si se ha presionado cualquier botón del mando
        if (Input.anyKeyDown)
        {
            // Cambiar a la escena "ZombieLand"
            SceneManager.LoadScene("ZombieLand");
        }
    }
}
