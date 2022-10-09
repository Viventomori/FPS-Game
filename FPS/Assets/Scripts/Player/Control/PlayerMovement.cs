using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    [SerializeField] private float speed = 12f;
    [SerializeField] private Joystick leftJoystick;

    private void Update()
    {
        float x = leftJoystick.Horizontal;
        float z = leftJoystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
