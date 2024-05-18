using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float rotationSpeed = 1f;

    void Update()
    {
        // Movimiento hacia adelante/atrás
        float forwardMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        // Rotación horizontal
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.Rotate(0, rotation, 0);

        // Rotación vertical
        float verticalRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        Camera.main.transform.Rotate(-verticalRotation, 0, 0);

        // Bloquear la rotación en el eje Z
        Vector3 currentRotation = Camera.main.transform.rotation.eulerAngles;
        currentRotation.z = 0;
        Camera.main.transform.rotation = Quaternion.Euler(currentRotation);

        // Guardar la posición actual en Y
        float currentYPosition = transform.position.y;

        // Aplicar movimiento
        Vector3 movement = new Vector3(0, 0, forwardMovement);
        transform.Translate(transform.rotation * movement, Space.World);

        // Restaurar la posición en Y
        Vector3 currentPosition = transform.position;
        currentPosition.y = currentYPosition;
        transform.position = currentPosition;

        // Rotación con respecto a la normal de la cámara
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position, transform.up, -rotationSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.position, transform.up, rotationSpeed);
        }
    }
}
